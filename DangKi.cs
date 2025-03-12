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
        
            string vaiTro = rdoSinhVien.Checked ? "Sinh viên" : "Thủ thư"; // Lấy chức vụ từ RadioButton

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-TLCPOEVM\\TRUONG;Initial Catalog=QLThuVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThemUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@VaiTro", vaiTro);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (vaiTro == "Sinh viên")
                        {
                            EditSinhVien editForm = new EditSinhVien(txtTaiKhoan.Text);
                            this.Hide();
                            editForm.ShowDialog();
                            this.Show();
                        }
                        else if (vaiTro == "Thủ thư")
                        {
                            EditThuThu editTT = new EditThuThu(txtTaiKhoan.Text);
                            this.Hide();
                            editTT.ShowDialog();
                            this.Show();
                        }

                        // Ẩn form đăng ký
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
