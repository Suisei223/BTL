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
        private string tenDangNhap;
        string connectionString = "Data Source=LAPTOP-TLCPOEVM\\TRUONG;Initial Catalog=QLThuVien;Integrated Security=True";

        public EditThuThu(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string quyenHan = rdoXem.Checked ? "Chỉ xem" : rdoXemSua.Checked ? "Xem và sửa" : "Tất cả quyền hạn";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO tblThuThu (MaThuThu, TenThuThu, SDT, Email, QuyenHan, TenDangNhap) 
                                 VALUES (@MaThuThu, @TenThuThu, @SDT, @Email, @QuyenHan, @TenDangNhap)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaThuThu", int.Parse(txtMaThuThu.Text));
                    cmd.Parameters.AddWithValue("@TenThuThu", txtTenThuThu.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@QuyenHan", quyenHan);
                    cmd.Parameters.AddWithValue("@TenDangNhap", this.tenDangNhap);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("Thêm thủ thư thành công!");
        }

        private void xn_Click(object sender, EventArgs e)
        {

        }
    }
}
