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
    public partial class EditThuThu : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        private string tenDangNhap;

        public EditThuThu(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void xn_Click(object sender, EventArgs e)
        {
            string hoTen = txtTenThuThu.Text.Trim();
            string quyen = txtQuyen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtTenThuThu, "Vui lòng nhập họ tên thủ thư.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(quyen))
            {
                errorProvider1.SetError(txtQuyen, "Vui lòng nhập quyền.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(sdt))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email.");
                isValid = false;
            }

            if (isValid)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ThemThuThu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@Quyen", quyen);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        TrangChuThuThu trangThuThu = new TrangChuThuThu();
                        trangThuThu.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(btnLuu, "Lỗi khi lưu thông tin: " + ex.Message);
                    }
                }
            }
        }

        private void EditThuThu_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = tenDangNhap;
            txtTenDangNhap.Enabled = false;
        }
    }
}
