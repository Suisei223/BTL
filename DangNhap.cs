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
    public partial class DangNhap : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;"
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT VaiTro FROM tblUser WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string vaiTro = reader["VaiTro"].ToString();
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (vaiTro == "Sinh viên")
                        {
                            TrangChuSinhVien editForm = new TrangChuSinhVien();
                            this.Hide();
                            editForm.ShowDialog();
                            this.Show();
                        }
                        else if (vaiTro == "Thủ thư")
                        {
                            TrangChuThuThu editTT = new TrangChuThuThu();
                            this.Hide();
                            editTT.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dk_Click(object sender, EventArgs e)
        {
            DangKi registerForm = new DangKi();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
