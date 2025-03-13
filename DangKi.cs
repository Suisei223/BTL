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
    public partial class DangKi : Form
    {
        string connectionString = "Server= DESKTOP-PA21PBT\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        
        public DangKi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;
            string vaiTro = rdoSinhVien.Checked ? "Sinh viên" : "Thủ thư";

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (matKhau != xacNhanMatKhau)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không khớp!");
                return;
            }
            if (CheckIfAccountExists(tenDangNhap))
            {
                errorProvider1.SetError(txtTaiKhoan, "Tài khoản đã tồn tại!");
                return;
            }

            string matKhauText = matKhau;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhauText);  
                cmd.Parameters.AddWithValue("@VaiTro", vaiTro);

                cmd.ExecuteNonQuery();

                this.Hide();
                if (vaiTro == "Sinh viên")
                {
                    EditSinhVien editForm = new EditSinhVien(tenDangNhap);  
                    editForm.ShowDialog();  
                }
                else if (vaiTro == "Thủ thư")
                {
                    EditThuThu editForm = new EditThuThu(tenDangNhap);  
                    editForm.ShowDialog();  
                }
                this.Close();
            }
        }

        private bool CheckIfAccountExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_KiemTraTaoTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", username);

                SqlParameter returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                return (int)returnValue.Value == -1; 
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }
        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }
        private void CheckPasswordMatch()
        {
            if (txtMatKhau.Text == txtXacNhanMatKhau.Text)
            {
                btnDangKy.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                btnDangKy.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}