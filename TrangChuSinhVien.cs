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
    public partial class TrangChuSinhVien : Form
    {
        private string TenDangNhap;
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public TrangChuSinhVien(string tenDangNhap)
        {
            InitializeComponent();
            this.TenDangNhap = tenDangNhap;
        }

        private void ktttcn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThongTinSinhVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
                dataGridView1.Columns[1].HeaderText = "Tên Sinh viên";
                dataGridView1.Columns[2].HeaderText = "Lớp";
                dataGridView1.Columns[3].HeaderText = "Ngành";
                dataGridView1.Columns[4].HeaderText = "Số điện thoại";
                dataGridView1.Columns[5].HeaderText = "Email";
                dataGridView1.Columns[6].HeaderText = "Tên đăng nhập";
            }
        }

        private void ktsdm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("sp_LayPhieuMuon_TheoTenDangNhap", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].HeaderText = "Mã Phiếu Mượn";
                    dataGridView1.Columns[1].HeaderText = "Mã Sinh Viên";
                    dataGridView1.Columns[2].HeaderText = "Tên Sinh Viên";
                    dataGridView1.Columns[3].HeaderText = "Ngày Mượn";
                    dataGridView1.Columns[4].HeaderText = "Hạn Trả";
                    dataGridView1.Columns[5].HeaderText = "Tên Thủ Thư";
                    dataGridView1.Columns[6].HeaderText = "Tên Sách";
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(ktsdm, "Lỗi lấy danh sách" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportSach frmReportSach = new frmReportSach();
            frmReportSach.ShowDialog();
        }

        private void tcs_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("sp_HienSach", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Mã Sách";
                dataGridView1.Columns[1].HeaderText = "Tên Sách";
                dataGridView1.Columns[2].HeaderText = "Số lượng";
                dataGridView1.Columns[3].HeaderText = "Thể Loại";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
