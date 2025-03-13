using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class TrangChuThuThu : Form
    {
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

        private void cssv_Click(object sender, EventArgs e)
        {
            
        }

        private void TrangChuThuThu_Load(object sender, EventArgs e)
        {

        }
    }
}
