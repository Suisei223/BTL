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
    public partial class EditPhieuMuon : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public EditPhieuMuon()
        {
            InitializeComponent();
        }

        private void ktcpm_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txtTenSinhVien.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                cmd.Parameters.AddWithValue("@TenSach", tenSach);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void LoadPhieuMuonData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void EditPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadPhieuMuonData();
        }

        private void n_Click(object sender, EventArgs e)
        {
            int maPhieuMuon = Convert.ToInt32(txtMaPhieuMuon.Text);
            int maSV = Convert.ToInt32(txtMaSinhVien.Text);
            string tenSinhVien = txtTenSinhVien.Text;
            string tenThuThu = txtTenThuThu.Text;
            string tenSach = txtTenSach.Text;
            DateTime ngayMuon = dateTimePickerNgayMuon.Value;
            DateTime hanTra = dateTimePickerHanTra.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                cmd.Parameters.AddWithValue("@HanTra", hanTra);
                cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text));
                cmd.Parameters.AddWithValue("@TenThuThu", tenThuThu);
                cmd.Parameters.AddWithValue("@MaSach", Convert.ToInt32(txtMaSach.Text));
                cmd.Parameters.AddWithValue("@TenSach", tenSach);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadPhieuMuonData();
            n.Text = "Nhập";
            x.Enabled = false; 
        }

        private void x_Click(object sender, EventArgs e)
        {
            int maPhieuMuon = Convert.ToInt32(txtMaPhieuMuon.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                conn.Open();
                cmd.ExecuteNonQuery(); 

                LoadPhieuMuonData();

                n.Text = "Nhập"; 
                x.Enabled = false; 
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtMaPhieuMuon.Text = row.Cells["MaPhieuMuon"].Value.ToString();
                txtMaSinhVien.Text = row.Cells["MaSV"].Value.ToString();
                txtTenSinhVien.Text = row.Cells["TenSinhVien"].Value.ToString();
                txtMaThuThu.Text = row.Cells["MaThuThu"].Value.ToString();
                txtTenThuThu.Text = row.Cells["TenThuThu"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                dateTimePickerNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dateTimePickerHanTra.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);

                n.Text = "Lưu";
                x.Enabled = true; 
            }
        }
    }
}
