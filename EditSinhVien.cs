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
        string connectionString = "Data Source=LAPTOP-TLCPOEVM\\TRUONG;Initial Catalog=QLThuVien;Integrated Security=True";

        private string tenDangNhap;

        public EditSinhVien(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }




        private void EditSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO tblSinhVien (MaSV, Ten, Lop, Nganh, SDT, Email, TenDangNhap) 
                                 VALUES (@MaSV, @Ten, @Lop, @Nganh, @SDT, @Email, @TenDangNhap)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", int.Parse(txtMaSV.Text));
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                    cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@TenDangNhap", this.tenDangNhap);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("Thêm sinh viên thành công!");
        }
    }
}
