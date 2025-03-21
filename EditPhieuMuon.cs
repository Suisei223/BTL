﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            errorProvider1.Clear();
            string maPhieuMuon = txtMaPhieuMuon.Text.Trim();
            string tenSinhVien = txtTenSinhVien.Text.Trim();
            string tenThuThu = txtTenThuThu.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string maThuThu = txtMaThuThu.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            DateTime? ngayMuon = dateTimePickerNgayMuon.Checked ? (DateTime?)dateTimePickerNgayMuon.Value : null;
            DateTime? hanTra = dateTimePickerHanTra.Checked ? (DateTime?)dateTimePickerHanTra.Value : null;

            if (string.IsNullOrEmpty(maPhieuMuon) && string.IsNullOrEmpty(tenSinhVien) && string.IsNullOrEmpty(tenThuThu) && string.IsNullOrEmpty(tenSach)
                && string.IsNullOrEmpty(maSinhVien) && string.IsNullOrEmpty(maThuThu) && string.IsNullOrEmpty(maSach) && !ngayMuon.HasValue && !hanTra.HasValue)
            {
                errorProvider1.SetError(ktcpm, "Vui lòng nhập ít nhất một trường: Mã Phiếu Mượn, Tên Sinh Viên, Tên Thủ Thư, Tên Sách, Mã Sinh Viên, Mã Thủ Thư, Mã Sách, Ngày Mượn hoặc Hạn Trả.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuMuon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhieuMuon", string.IsNullOrEmpty(maPhieuMuon) ? (object)DBNull.Value : Convert.ToInt32(maPhieuMuon));
                    cmd.Parameters.AddWithValue("@MaSV", string.IsNullOrEmpty(maSinhVien) ? (object)DBNull.Value : Convert.ToInt32(maSinhVien));
                    cmd.Parameters.AddWithValue("@TenSinhVien", string.IsNullOrEmpty(tenSinhVien) ? (object)DBNull.Value : (object)tenSinhVien);
                    cmd.Parameters.AddWithValue("@MaThuThu", string.IsNullOrEmpty(maThuThu) ? (object)DBNull.Value : Convert.ToInt32(maThuThu));
                    cmd.Parameters.AddWithValue("@TenThuThu", string.IsNullOrEmpty(tenThuThu) ? (object)DBNull.Value : (object)tenThuThu);
                    cmd.Parameters.AddWithValue("@MaSach", string.IsNullOrEmpty(maSach) ? (object)DBNull.Value : Convert.ToInt32(maSach));
                    cmd.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(tenSach) ? (object)DBNull.Value : (object)tenSach);
                    cmd.Parameters.AddWithValue("@NgayMuon", !ngayMuon.HasValue ? (object)DBNull.Value : ngayMuon.Value);
                    cmd.Parameters.AddWithValue("@HanTra", !hanTra.HasValue ? (object)DBNull.Value : hanTra.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(ktcpm, "Lỗi khi tìm kiếm phiếu mượn: " + ex.Message);
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
            try
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
            catch (SqlException ex)
            {
                errorProvider1.SetError(dataGridView1, "Lỗi khi tải dữ liệu phiếu mượn: " + ex.Message);
            }
        }

        private void EditPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadPhieuMuonData();
            x.Enabled = false;
        }

        private void n_Click(object sender, EventArgs e)
        {
            DateTime ngayMuon = dateTimePickerNgayMuon.Value;
            DateTime hanTra = dateTimePickerHanTra.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (n.Text == "Lưu")
                    {
                        SqlCommand cmd = new SqlCommand("sp_SuaPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", Convert.ToInt32(txtMaPhieuMuon.Text));
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text));
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text));
                        cmd.Parameters.AddWithValue("@MaSach", Convert.ToInt32(txtMaSach.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        errorProvider1.Clear();
                        LoadPhieuMuonData();
                        n.Text = "Nhập";  
                        x.Enabled = false;
                        ClearFormFields();
                    }
                    else  
                    {
                        SqlCommand cmd = new SqlCommand("sp_ThemPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text));
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text));
                        cmd.Parameters.AddWithValue("@MaSach", Convert.ToInt32(txtMaSach.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        errorProvider1.Clear();
                        LoadPhieuMuonData();
                    }
                }
            }
            catch (SqlException ex)
            {
                errorProvider1.SetError(n, "Lỗi khi thêm/sửa phiếu mượn: " + ex.Message);
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int maPhieuMuon;
            if (!int.TryParse(txtMaPhieuMuon.Text, out maPhieuMuon))
            {
                errorProvider1.SetError(txtMaPhieuMuon, "Mã phiếu mượn không hợp lệ.");
                return;
            }

            try
            {
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
            catch (SqlException ex)
            {
                errorProvider1.SetError(x, "Lỗi khi xóa phiếu mượn: " + ex.Message);
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
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                n.Text = "Lưu";
                x.Enabled = true;
            }
        }
        private void ClearFormFields()
        {
            txtMaPhieuMuon.Clear();
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtMaThuThu.Clear();
            txtTenThuThu.Clear();
            txtTenSach.Clear();
            txtMaSach.Clear();
            dateTimePickerNgayMuon.Value = DateTime.Now;  
            dateTimePickerHanTra.Value = DateTime.Now;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                errorProvider1.SetError(btnIn, "Vui lòng chọn một phiếu mượn trước khi in.");
                return;
            }

            try
            {
                int maSV = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaSV"].Value);
                ReportDocument rptDoc = new ReportDocument();
                rptDoc.Load("D:\\Lập trình hướng sự kiện\\BTL-Truong\\BTL\\CrystalReport1.rpt");
                rptDoc.SetParameterValue("MaSV", maSV);

                rptDoc.VerifyDatabase();

                crystalReportViewer1.ReportSource = rptDoc;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(btnIn, "Lỗi tạo báo cáo." + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n.Text == "Lưu")
            {
                ResetForm();
            }
            else
            {
                this.Close();
            }
        }

        private void ResetForm()
        {
            errorProvider1.Clear();  
            txtMaPhieuMuon.Clear();
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtMaThuThu.Clear();
            txtTenThuThu.Clear();
            txtTenSach.Clear();
            txtMaSach.Clear();
            dateTimePickerNgayMuon.Value = DateTime.Now;
            dateTimePickerHanTra.Value = DateTime.Now;

            n.Text = "Nhập"; 
            x.Enabled = false; 
            LoadPhieuMuonData();
        }

    }
}
