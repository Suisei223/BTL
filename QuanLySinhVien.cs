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
    public partial class QuanLySinhVien : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        private bool isEditing = false;

        public QuanLySinhVien()
        {
            InitializeComponent();
            LoadData();
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC sp_GetAllSinhVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void ResetForm()
        {
            txtMa.Text = txtTen.Text = txtLop.Text = txtNganh.Text = txtSDT.Text = txtEmail.Text = txtTenDangNhap.Text = "";
            btnThem.Text = "Thêm";
            btnXoa.Enabled = false;
            isEditing = false;
            errorProvider1.Clear();
            LoadData();
        }

        private bool ValidateFields()
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                errorProvider1.SetError(txtTen, "Tên không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                errorProvider1.SetError(txtLop, "Lớp không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNganh.Text))
            {
                errorProvider1.SetError(txtNganh, "Ngành không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                valid = false;
            }
            return valid;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(isEditing ? "sp_SuaSinhVien" : "sp_ThemSinhVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);

                if (isEditing)
                    cmd.Parameters.AddWithValue("@MaSV", int.Parse(txtMa.Text));

                cmd.ExecuteNonQuery();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_XoaSinhVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSV", int.Parse(txtMa.Text));
                cmd.ExecuteNonQuery();
                ResetForm();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(btnSua, "Chọn một sinh viên để sửa!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtMa.Text = row.Cells["MaSV"].Value.ToString();
            txtTen.Text = row.Cells["Ten"].Value.ToString();
            txtLop.Text = row.Cells["Lop"].Value.ToString();
            txtNganh.Text = row.Cells["Nganh"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();

            isEditing = true;
            btnThem.Text = "Lưu";
            btnXoa.Enabled = true;
            errorProvider1.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_TimKiemSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", string.IsNullOrEmpty(txtMa.Text) ? (object)DBNull.Value : int.Parse(txtMa.Text));
                    cmd.Parameters.AddWithValue("@Ten", string.IsNullOrEmpty(txtTen.Text) ? (object)DBNull.Value : txtTen.Text);
                    cmd.Parameters.AddWithValue("@Lop", string.IsNullOrEmpty(txtLop.Text) ? (object)DBNull.Value : txtLop.Text);
                    cmd.Parameters.AddWithValue("@Nganh", string.IsNullOrEmpty(txtNganh.Text) ? (object)DBNull.Value : txtNganh.Text);
                    cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(txtSDT.Text) ? (object)DBNull.Value : txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", string.IsNullOrEmpty(txtTenDangNhap.Text) ? (object)DBNull.Value : txtTenDangNhap.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
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
    }
}
