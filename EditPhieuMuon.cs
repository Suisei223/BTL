using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class EditPhieuMuon : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public EditPhieuMuon()
        {
            InitializeComponent();
        }

        private void ktcpm_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txtTenSinhVien.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                    cmd.Parameters.AddWithValue("@TenSach", tenSach);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(ktcpm, "Lỗi khi tìm kiếm phiếu mượn: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void LoadPhieuMuonData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetAllPhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                errorProvider1.SetError(dataGridView1, "Lỗi khi tải dữ liệu phiếu mượn: " + ex.Message);
            }
        }

        private void EditPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadPhieuMuonData();
            x.Enabled = false;
        }

        private void n_Click(object sender, EventArgs e)
        {
            int maPhieuMuon;
            if (!int.TryParse(txtMaPhieuMuon.Text, out maPhieuMuon))
            {
                errorProvider1.SetError(txtMaPhieuMuon, "Mã phiếu mượn không hợp lệ.");
                return;
            }

            string tenSinhVien = txtTenSinhVien.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            DateTime ngayMuon = dateTimePickerNgayMuon.Value;
            DateTime hanTra = dateTimePickerHanTra.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Nếu nút là "Lưu", thực hiện cập nhật
                    if (n.Text == "Lưu")
                    {
                        SqlCommand cmd = new SqlCommand("sp_SuaPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text)); // MaSinhVien
                        cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text)); // MaThuThu
                        cmd.Parameters.AddWithValue("@TenThuThu", txtTenThuThu.Text);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        LoadPhieuMuonData();
                        n.Text = "Nhập";  
                        x.Enabled = false;
                        ClearFormFields();
                    }
                    else  
                    {
                        SqlCommand cmd = new SqlCommand("sp_ThemPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text)); // MaSinhVien
                        cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text)); // MaThuThu
                        cmd.Parameters.AddWithValue("@TenThuThu", txtTenThuThu.Text);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        LoadPhieuMuonData();
                    }
                }
            }
            catch (SqlException ex)
            {
                errorProvider1.SetError(n, "Lỗi khi thêm/sửa phiếu mượn: " + ex.Message);
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            int maPhieuMuon;
            if (!int.TryParse(txtMaPhieuMuon.Text, out maPhieuMuon))
            {
                errorProvider1.SetError(txtMaPhieuMuon, "Mã phiếu mượn không hợp lệ.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_XoaPhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadPhieuMuonData();
                    n.Text = "Nhập";
                    x.Enabled = false;
                }
            }
            catch (SqlException ex)
            {
                errorProvider1.SetError(x, "Lỗi khi xóa phiếu mượn: " + ex.Message);
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtMaPhieuMuon.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaSinhVien.Text = row.Cells["MaSV"].Value.ToString();
                txtTenSinhVien.Text = row.Cells["TenSinhVien"].Value.ToString();
                txtMaThuThu.Text = row.Cells["MaThuThu"].Value.ToString();
                txtTenThuThu.Text = row.Cells["TenThuThu"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                dateTimePickerNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dateTimePickerHanTra.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                n.Text = "Lưu";
                x.Enabled = true;
            }
        }
        private void ClearFormFields()
        {
            txtMaPhieuMuon.Clear();
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtMaThuThu.Clear();
            txtTenThuThu.Clear();
            txtTenSach.Clear();
            txtMaSach.Clear();
            dateTimePickerNgayMuon.Value = DateTime.Now;  // Set to current date or default date
            dateTimePickerHanTra.Value = DateTime.Now;
        }
    }
}
