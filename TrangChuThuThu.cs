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
    public partial class TrangChuThuThu : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public TrangChuThuThu()
        {
            InitializeComponent();
        }

        private void ttk_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void TrangChuThuThu_Load(object sender, EventArgs e)
        {

        }

        private void LoadData(string procName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(procName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                if (procName == "sp_GetAllSinhVien")
                {
                    dataGridView1.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
                    dataGridView1.Columns["Ten"].HeaderText = "Tên Sinh Viên";
                    dataGridView1.Columns["Lop"].HeaderText = "Lớp";
                    dataGridView1.Columns["Nganh"].HeaderText = "Ngành";
                    dataGridView1.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dataGridView1.Columns["Email"].HeaderText = "Email";
                }
                else if (procName == "sp_GetAllThuThu")
                {
                    dataGridView1.Columns["MaThuThu"].HeaderText = "Mã Thủ Thư";
                    dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
                    dataGridView1.Columns["Quyen"].HeaderText = "Quyền";
                    dataGridView1.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dataGridView1.Columns["Email"].HeaderText = "Email";
                }
                else if (procName == "sp_GetAllSach")
                {
                    dataGridView1.Columns["MaSach"].HeaderText = "Mã Sách";
                    dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
                    dataGridView1.Columns["SoLuong"].HeaderText = "Số Lượng";
                    dataGridView1.Columns["TheLoai"].HeaderText = "Thể Loại";
                }
                else if (procName == "sp_GetAllPhieuMuon")
                {
                    dataGridView1.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
                    dataGridView1.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
                    dataGridView1.Columns["TenSinhVien"].HeaderText = "Tên Sinh Viên";
                    dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                    dataGridView1.Columns["HanTra"].HeaderText = "Hạn Trả";
                    dataGridView1.Columns["MaThuThu"].HeaderText = "Mã Thủ Thư";
                    dataGridView1.Columns["TenThuThu"].HeaderText = "Tên Thủ Thư";
                    dataGridView1.Columns["MaSach"].HeaderText = "Mã Sách";
                    dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
                }
            }
        }

        private void ttsv_Click(object sender, EventArgs e)
        {
            LoadData("sp_GetAllSinhVien");
        }

        private void tttt_Click(object sender, EventArgs e)
        {
            LoadData("sp_GetAllThuThu");
        }

        private void ttpm_Click(object sender, EventArgs e)
        {
            LoadData("sp_GetAllSach");
        }

        private void cssv_Click(object sender, EventArgs e)
        {
            LoadData("sp_GetAllPhieuMuon");
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPhieuMuon phieuMuonForm = new EditPhieuMuon();
            phieuMuonForm.MdiParent = this;
            phieuMuonForm.Show();
            phieuMuonForm.BringToFront();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
