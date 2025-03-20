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
            this.components = new System.ComponentModel.Container();
            this.tcsv = new System.Windows.Forms.Label();
            this.ktsdm = new System.Windows.Forms.Button();
            this.tcs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ktttcn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcsv
            // 
            this.tcsv.AutoSize = true;
            this.tcsv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcsv.Location = new System.Drawing.Point(301, 9);
            this.tcsv.Name = "tcsv";
            this.tcsv.Size = new System.Drawing.Size(197, 26);
            this.tcsv.TabIndex = 0;
            this.tcsv.Text = "Trang chủ sinh viên";
            // 
            // ktsdm
            // 
            this.ktsdm.Location = new System.Drawing.Point(44, 269);
            this.ktsdm.Name = "ktsdm";
            this.ktsdm.Size = new System.Drawing.Size(143, 45);
            this.ktsdm.TabIndex = 2;
            this.ktsdm.TabStop = false;
            this.ktsdm.Text = "Kiểm tra sách đã mượn";
            this.ktsdm.UseVisualStyleBackColor = true;
            this.ktsdm.Click += new System.EventHandler(this.ktsdm_Click);
            // 
            // tcs
            // 
            this.tcs.Location = new System.Drawing.Point(44, 329);
            this.tcs.Name = "tcs";
            this.tcs.Size = new System.Drawing.Size(143, 45);
            this.tcs.TabIndex = 3;
            this.tcs.TabStop = false;
            this.tcs.Text = "Tra cứu sách";
            this.tcs.UseVisualStyleBackColor = true;
            this.tcs.Click += new System.EventHandler(this.tcs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 207);
            this.dataGridView1.TabIndex = 4;
            // 
            // ktttcn
            // 
            this.ktttcn.Location = new System.Drawing.Point(267, 269);
            this.ktttcn.Name = "ktttcn";
            this.ktttcn.Size = new System.Drawing.Size(133, 45);
            this.ktttcn.TabIndex = 6;
            this.ktttcn.Text = "Kiểm tra thông tin cá nhân";
            this.ktttcn.UseVisualStyleBackColor = true;
            this.ktttcn.Click += new System.EventHandler(this.ktttcn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "In danh sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrangChuSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ktttcn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tcs);
            this.Controls.Add(this.ktsdm);
            this.Controls.Add(this.tcsv);
            this.IsMdiContainer = true;
            this.Name = "TrangChuSinhVien";
            this.Text = "TrangChuSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tcsv;
        private System.Windows.Forms.Button ktsdm;
        private System.Windows.Forms.Button tcs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ktttcn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}