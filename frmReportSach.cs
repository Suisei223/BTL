using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReportSach : Form
    {
        string connectionString = "Server= LAPTOP-29QKNBEH\\SQLEXPRESS; Database= QuanLyMuonTraSach; Integrated Security=True;";
        public frmReportSach()
        {
            InitializeComponent();
            LoadReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void LoadReport()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("EXEC sp_GetAllSach", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblSach");

                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"D:\Lập trình hướng sự kiện\BTL-Truong\BTL\InDSSach.rpt"); 
                rpt.SetDataSource(ds.Tables["tblSach"]); 
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
        }
    }
}
