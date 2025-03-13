﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL
{
    public partial class DangNhap : Form
    {
        string connectionString = "Server= DESKTOP-PA21PBT\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dn_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text; 
            string password = txtMatKhau.Text; 
            string role = CheckLogin(username, password);

            Console.WriteLine("Role: " + role);  // Debug log

            if (role != null)
            {
                if (role == "Sinh viên")
                {
                    this.Hide();    
                    TrangChuSinhVien trangSinhVien = new TrangChuSinhVien();
                    trangSinhVien.ShowDialog();
                    this.Show();

                }
                else if (role == "Thủ thư")
                {
                    this.Hide();
                    TrangChuThuThu trangThuThu = new TrangChuThuThu();
                    trangThuThu.ShowDialog();
                    this.Show();
                }
                
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
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                cmd.Parameters.AddWithValue("@MatKhau", password);

                SqlParameter roleParam = new SqlParameter("@VaiTro", SqlDbType.NVarChar, 50);
                roleParam.Direction = ParameterDirection.Output; 
                cmd.Parameters.Add(roleParam);
                cnn.Open();
                cmd.ExecuteNonQuery(); 
                cnn.Close();
                if (roleParam.Value == DBNull.Value)
                    role = null;
                else
                    role = roleParam.Value.ToString().Trim();
            }
            return role;
        }
    }
}
