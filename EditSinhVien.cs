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
    public partial class EditSinhVien : Form
    {
        string connectionString = "Server= DESKTOP-PA21PBT\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        private string tenDangNhap;

        public EditSinhVien(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void EditSinhVien_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = tenDangNhap;
            txtTenDangNhap.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txtTen.Text.Trim();
            string lop = txtLop.Text.Trim();
            string nganh = txtNganh.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            bool isValid = true;
            errorProvider1.Clear();  

            if (string.IsNullOrEmpty(tenSinhVien))
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập tên sinh viên.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(lop))
            {
                errorProvider1.SetError(txtLop, "Vui lòng nhập lớp.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(nganh))
            {
                errorProvider1.SetError(txtNganh, "Vui lòng nhập ngành.");
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
                    SqlCommand cmd = new SqlCommand("sp_ThemSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Ten", tenSinhVien);
                    cmd.Parameters.AddWithValue("@Lop", lop);
                    cmd.Parameters.AddWithValue("@Nganh", nganh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    try
                    { 
                        TrangChuSinhVien trangSinhVien = new TrangChuSinhVien();
                        trangSinhVien.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(btnLuu, "Lỗi khi lưu thông tin: " + ex.Message);
                    }
                }
            }
        }
    }
}
