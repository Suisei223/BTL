namespace BTL
{
    partial class TrangChuSinhVien
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
            this.tcsv = new System.Windows.Forms.Label();
            this.ttk = new System.Windows.Forms.Button();
            this.ktsdm = new System.Windows.Forms.Button();
            this.tcs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcsv
            // 
            this.tcsv.AutoSize = true;
            this.tcsv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcsv.Location = new System.Drawing.Point(283, 28);
            this.tcsv.Name = "tcsv";
            this.tcsv.Size = new System.Drawing.Size(197, 26);
            this.tcsv.TabIndex = 0;
            this.tcsv.Text = "Trang chủ sinh viên";
            // 
            // ttk
            // 
            this.ttk.Location = new System.Drawing.Point(99, 364);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(106, 45);
            this.ttk.TabIndex = 1;
            this.ttk.TabStop = false;
            this.ttk.Text = "Thoát tài khoản";
            this.ttk.UseVisualStyleBackColor = true;
            // 
            // ktsdm
            // 
            this.ktsdm.Location = new System.Drawing.Point(316, 364);
            this.ktsdm.Name = "ktsdm";
            this.ktsdm.Size = new System.Drawing.Size(143, 45);
            this.ktsdm.TabIndex = 2;
            this.ktsdm.TabStop = false;
            this.ktsdm.Text = "Kiểm tra sách đã mượn";
            this.ktsdm.UseVisualStyleBackColor = true;
            // 
            // tcs
            // 
            this.tcs.Location = new System.Drawing.Point(562, 364);
            this.tcs.Name = "tcs";
            this.tcs.Size = new System.Drawing.Size(122, 45);
            this.tcs.TabIndex = 3;
            this.tcs.TabStop = false;
            this.tcs.Text = "Tra cứu sách";
            this.tcs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 239);
            this.dataGridView1.TabIndex = 4;
            // 
            // TrangChuSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tcs);
            this.Controls.Add(this.ktsdm);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.tcsv);
            this.Name = "TrangChuSinhVien";
            this.Text = "TrangChuSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tcsv;
        private System.Windows.Forms.Button ttk;
        private System.Windows.Forms.Button ktsdm;
        private System.Windows.Forms.Button tcs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}