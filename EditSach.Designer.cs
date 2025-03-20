namespace BTL
{
    partial class EditSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cs = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            this.xn = new System.Windows.Forms.Button();
            this.dssdc = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs.Location = new System.Drawing.Point(403, 9);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(175, 29);
            this.cs.TabIndex = 1;
            this.cs.Text = "Chỉnh sửa sách";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(327, 81);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(58, 16);
            this.ms.TabIndex = 2;
            this.ms.Text = "Mã sách";
            // 
            // ts
            // 
            this.ts.AutoSize = true;
            this.ts.Location = new System.Drawing.Point(556, 81);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(63, 16);
            this.ts.TabIndex = 3;
            this.ts.Text = "Tên sách";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Location = new System.Drawing.Point(327, 149);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(56, 16);
            this.tl.TabIndex = 4;
            this.tl.Text = "Thể loại";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(559, 149);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(60, 16);
            this.sl.TabIndex = 5;
            this.sl.Text = "Số lượng";
            // 
            // xn
            // 
            this.xn.Location = new System.Drawing.Point(625, 249);
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(92, 28);
            this.xn.TabIndex = 5;
            this.xn.Text = "Xác nhận";
            this.xn.UseVisualStyleBackColor = true;
            this.xn.Click += new System.EventHandler(this.xn_Click);
            // 
            // dssdc
            // 
            this.dssdc.AutoSize = true;
            this.dssdc.Location = new System.Drawing.Point(12, 279);
            this.dssdc.Name = "dssdc";
            this.dssdc.Size = new System.Drawing.Size(140, 16);
            this.dssdc.TabIndex = 8;
            this.dssdc.Text = "Danh sách sách đã có";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(663, 78);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(100, 22);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(421, 75);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(421, 143);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(100, 22);
            this.txtTheLoai.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(663, 149);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(343, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 28);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(483, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 32);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(483, 249);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 28);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(625, 189);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(92, 32);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 592);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.dssdc);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditSach";
            this.Text = "Chỉnh sửa sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cs;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Label ts;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.Button xn;
        private System.Windows.Forms.Label dssdc;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}