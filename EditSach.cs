using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class EditSach : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        private bool isEditing = false;

        public EditSach()
        {
            InitializeComponent();
            LoadData();
            btnXoa.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtTheLoai.Text = row.Cells["TheLoai"].Value.ToString();

                btnThem.Text = "Lưu";  // Đổi tên nút Nhập thành Lưu
                btnXoa.Enabled = true; // Hiện nút Xóa
                isEditing = true;
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC sp_HienSach", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtTheLoai.Text))
            {
                errorProvider1.SetError(btnThem, "Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                int maTheLoai = int.Parse(txtTheLoai.Text);

                if (isEditing)
                {
                    cmd = new SqlCommand("sp_SuaSach", conn);
                    cmd.Parameters.AddWithValue("@MaSach", int.Parse(txtMaSach.Text));
                }
                else
                {
                    cmd = new SqlCommand("sp_ThemSach", conn);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@TheLoai", maTheLoai);

                try
                {
                    cmd.ExecuteNonQuery();
                    ResetForm();
                    LoadData();
                }
                catch (SqlException ex)
                {
                    errorProvider1.SetError(btnThem, ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                string tenTheLoai = row.Cells["TenTheLoai"].Value.ToString();
                int maTheLoai = LayMaTheLoai(tenTheLoai); 

                if (maTheLoai == -1)
                {
                    errorProvider1.SetError(txtTheLoai, "Thể loại không hợp lệ.");
                    return;
                }

                txtTheLoai.Text = maTheLoai.ToString(); 

                btnThem.Text = "Lưu";
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                errorProvider1.SetError(btnXoa, "Không có sách nào được chọn để xóa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSach", int.Parse(txtMaSach.Text));
                cmd.ExecuteNonQuery();
            }

            ResetForm();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSach", string.IsNullOrEmpty(txtMaSach.Text) ? (object)DBNull.Value : txtMaSach.Text);
                cmd.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(txtTenSach.Text) ? (object)DBNull.Value : txtTenSach.Text);
                cmd.Parameters.AddWithValue("@SoLuong", string.IsNullOrEmpty(txtSoLuong.Text) ? (object)DBNull.Value : txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@TheLoai", string.IsNullOrEmpty(txtTheLoai.Text) ? (object)DBNull.Value : txtTheLoai.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportSach reportForm = new frmReportSach();
            reportForm.ShowDialog();
        }

        private void xn_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Lưu")
            {
                ResetForm();
            }
            else
            {
                this.Close(); 
            }
        }

        private void ResetForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtTheLoai.Clear();

            btnThem.Text = "Nhập"; // Đổi lại nút về trạng thái Nhập
            btnXoa.Enabled = false; // Ẩn nút Xóa
            isEditing = false;
        }

        private int LayMaTheLoai(string tenTheLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayMaTheLoai", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                    SqlParameter outputParam = new SqlParameter("@MaTheLoai", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);
                    cmd.ExecuteNonQuery();

                    if (outputParam.Value == DBNull.Value)
                    {
                        return -1;
                    }
                    return (int)outputParam.Value;
                }
            }
        }

    }
}
