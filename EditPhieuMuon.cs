using CrystalDecisions.CrystalReports.Engine;
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

                    cmd.Parameters.AddWithValue("@MaPhieuMuon", string.IsNullOrEmpty(maPhieuMuon) ? DBNull.Value : (object)maPhieuMuon);
                    cmd.Parameters.AddWithValue("@TenSinhVien", string.IsNullOrEmpty(tenSinhVien) ? DBNull.Value : (object)tenSinhVien);
                    cmd.Parameters.AddWithValue("@TenThuThu", string.IsNullOrEmpty(tenThuThu) ? DBNull.Value : (object)tenThuThu);
                    cmd.Parameters.AddWithValue("@TenSach", string.IsNullOrEmpty(tenSach) ? DBNull.Value : (object)tenSach);
                    cmd.Parameters.AddWithValue("@MaSinhVien", string.IsNullOrEmpty(maSinhVien) ? DBNull.Value : (object)maSinhVien);
                    cmd.Parameters.AddWithValue("@MaThuThu", string.IsNullOrEmpty(maThuThu) ? DBNull.Value : (object)maThuThu);
                    cmd.Parameters.AddWithValue("@MaSach", string.IsNullOrEmpty(maSach) ? DBNull.Value : (object)maSach);
                    cmd.Parameters.AddWithValue("@NgayMuon", !ngayMuon.HasValue ? DBNull.Value : (object)ngayMuon);
                    cmd.Parameters.AddWithValue("@HanTra", !hanTra.HasValue ? DBNull.Value : (object)hanTra);

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
            int maPhieuMuon;
            if (!int.TryParse(txtMaPhieuMuon.Text, out maPhieuMuon))
            {
                errorProvider1.SetError(txtMaPhieuMuon, "Mã phiếu mượn không hợp lệ.");
                return;
            }

            string tenSinhVien = txtTenSinhVien.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            DateTime ngayMuon = dateTimePickerNgayMuon.Value;
            DateTime hanTra = dateTimePickerHanTra.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Nếu nút là "Lưu", thực hiện cập nhật
                    if (n.Text == "Lưu")
                    {
                        SqlCommand cmd = new SqlCommand("sp_SuaPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text)); // MaSinhVien
                        cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text)); // MaThuThu
                        cmd.Parameters.AddWithValue("@TenThuThu", txtTenThuThu.Text);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        LoadPhieuMuonData();
                        n.Text = "Nhập";  
                        x.Enabled = false;
                        ClearFormFields();
                    }
                    else  
                    {
                        SqlCommand cmd = new SqlCommand("sp_ThemPhieuMuon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        cmd.Parameters.AddWithValue("@MaSV", Convert.ToInt32(txtMaSinhVien.Text)); // MaSinhVien
                        cmd.Parameters.AddWithValue("@TenSinhVien", tenSinhVien);
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        cmd.Parameters.AddWithValue("@HanTra", hanTra);
                        cmd.Parameters.AddWithValue("@MaThuThu", Convert.ToInt32(txtMaThuThu.Text)); // MaThuThu
                        cmd.Parameters.AddWithValue("@TenThuThu", txtTenThuThu.Text);
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

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
            dateTimePickerNgayMuon.Value = DateTime.Now;  // Set to current date or default date
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
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSV = selectedRow.Cells["MaSV"].Value.ToString();

                ReportDocument rptDoc = new ReportDocument();
                string reportPath = "D:\\Lập trình hướng sự kiện\\BTL-Truong\\BTL\\CrystalReport1.rpt";
                rptDoc.Load(reportPath);

                ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
                discreteValue.Value = maSV;

                ParameterFieldDefinitions parameterFields = rptDoc.DataDefinition.ParameterFields;
                ParameterFieldDefinition parameterField = parameterFields["MaSV"];

                ParameterValues paramValues = new ParameterValues();
                paramValues.Add(discreteValue);
                parameterField.ApplyCurrentValues(paramValues);

                rptDoc.VerifyDatabase();

                crystalReportViewer1.ReportSource = rptDoc;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(btnIn, "Lỗi tạo báo cáo.");
                //MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
