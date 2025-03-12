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
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text; 
            string password = txtMatKhau.Text; 
            string role = CheckLogin(username, password);

            if (role != null)
            {
                if (role == "Sinh viên")
                {
                    TrangChuSinhVien trangSinhVien = new TrangChuSinhVien();
                    trangSinhVien.Show();
                }
                else if (role == "Thủ thư")
                {
                    TrangChuThuThu trangThuThu = new TrangChuThuThu();
                    trangThuThu.Show();
                }
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, "Tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void dk_Click(object sender, EventArgs e)
        {
            DangKi registerForm = new DangKi();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
        private string CheckLogin(string username, string password)
        {
            string role = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                cmd.Parameters.AddWithValue("@MatKhau", password);

                SqlParameter roleParam = new SqlParameter("@VaiTro", SqlDbType.NVarChar, 50);
                roleParam.Direction = ParameterDirection.Output; 
                cmd.Parameters.Add(roleParam);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery(); 
                    connection.Close();
                    role = roleParam.Value.ToString(); 
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtTaiKhoan, "Tài khoản hoặc mật khẩu không đúng");
                }
            }
            return role;
        }
    }
}
