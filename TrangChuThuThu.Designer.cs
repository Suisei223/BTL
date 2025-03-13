namespace BTL
{
    partial class TrangChuThuThu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tctt = new System.Windows.Forms.Label();
            this.ttk = new System.Windows.Forms.Button();
            this.ttsv = new System.Windows.Forms.Button();
            this.tttt = new System.Windows.Forms.Button();
            this.cssv = new System.Windows.Forms.Button();
            this.ttpm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.phiếuMượnToolStripMenuItem,
            this.sinhViênToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Quản lý";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            this.phiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tctt
            // 
            this.tctt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctt.AutoSize = true;
            this.tctt.Location = new System.Drawing.Point(407, 44);
            this.tctt.Name = "tctt";
            this.tctt.Size = new System.Drawing.Size(107, 16);
            this.tctt.TabIndex = 0;
            this.tctt.Text = "Trang chủ thủ thư";
            // 
            // ttk
            // 
            this.ttk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ttk.Location = new System.Drawing.Point(24, 621);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(173, 41);
            this.ttk.TabIndex = 9;
            this.ttk.Text = "Thoát tài khoản";
            this.ttk.UseVisualStyleBackColor = true;
            this.ttk.Click += new System.EventHandler(this.ttk_Click);
            // 
            // ttsv
            // 
            this.ttsv.Location = new System.Drawing.Point(24, 87);
            this.ttsv.Name = "ttsv";
            this.ttsv.Size = new System.Drawing.Size(173, 48);
            this.ttsv.TabIndex = 2;
            this.ttsv.Text = "Thông tin sinh viên";
            this.ttsv.UseVisualStyleBackColor = true;
            this.ttsv.Click += new System.EventHandler(this.ttsv_Click);
            // 
            // tttt
            // 
            this.tttt.Location = new System.Drawing.Point(24, 146);
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(173, 47);
            this.tttt.TabIndex = 3;
            this.tttt.Text = "Thông tin thủ thư ";
            this.tttt.UseVisualStyleBackColor = true;
            this.tttt.Click += new System.EventHandler(this.tttt_Click);
            // 
            // cssv
            // 
            this.cssv.Location = new System.Drawing.Point(24, 270);
            this.cssv.Name = "cssv";
            this.cssv.Size = new System.Drawing.Size(173, 48);
            this.cssv.TabIndex = 4;
            this.cssv.Text = "Thông tin sách";
            this.cssv.UseVisualStyleBackColor = true;
            this.cssv.Click += new System.EventHandler(this.cssv_Click);
            // 
            // ttpm
            // 
            this.ttpm.Location = new System.Drawing.Point(24, 204);
            this.ttpm.Name = "ttpm";
            this.ttpm.Size = new System.Drawing.Size(173, 48);
            this.ttpm.TabIndex = 8;
            this.ttpm.Text = "Thông tin phiếu mượn";
            this.ttpm.UseVisualStyleBackColor = true;
            this.ttpm.Click += new System.EventHandler(this.ttpm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 575);
            this.dataGridView1.TabIndex = 1;
            // 
            // TrangChuThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 694);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.ttpm);
            this.Controls.Add(this.cssv);
            this.Controls.Add(this.tttt);
            this.Controls.Add(this.ttsv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tctt);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChuThuThu";
            this.Text = "TrangChuThuThu";
            this.Load += new System.EventHandler(this.TrangChuThuThu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label tctt;
        private System.Windows.Forms.Button ttk;
        private System.Windows.Forms.Button ttsv;
        private System.Windows.Forms.Button tttt;
        private System.Windows.Forms.Button cssv;
        private System.Windows.Forms.Button ttpm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}