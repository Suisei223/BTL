namespace BTL
{
    partial class EditCTPhieuMuon
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
            this.csctpm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xn = new System.Windows.Forms.Button();
            this.nhapslm = new System.Windows.Forms.TextBox();
            this.nhapms = new System.Windows.Forms.TextBox();
            this.nhapspm = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dspmct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // csctpm
            // 
            this.csctpm.AutoSize = true;
            this.csctpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csctpm.Location = new System.Drawing.Point(201, 38);
            this.csctpm.Name = "csctpm";
            this.csctpm.Size = new System.Drawing.Size(326, 29);
            this.csctpm.TabIndex = 0;
            this.csctpm.Text = "Chỉnh sửa chi tiết phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số phiếu mượn";
            // 
            // xn
            // 
            this.xn.Location = new System.Drawing.Point(334, 384);
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(136, 54);
            this.xn.TabIndex = 4;
            this.xn.Text = "Xác nhận";
            this.xn.UseVisualStyleBackColor = true;
            // 
            // nhapslm
            // 
            this.nhapslm.Location = new System.Drawing.Point(187, 335);
            this.nhapslm.Name = "nhapslm";
            this.nhapslm.Size = new System.Drawing.Size(100, 22);
            this.nhapslm.TabIndex = 3;
            // 
            // nhapms
            // 
            this.nhapms.Location = new System.Drawing.Point(187, 241);
            this.nhapms.Name = "nhapms";
            this.nhapms.Size = new System.Drawing.Size(100, 22);
            this.nhapms.TabIndex = 2;
            // 
            // nhapspm
            // 
            this.nhapspm.Location = new System.Drawing.Point(187, 151);
            this.nhapspm.Name = "nhapspm";
            this.nhapspm.Size = new System.Drawing.Size(100, 22);
            this.nhapspm.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(293, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // dspmct
            // 
            this.dspmct.AutoSize = true;
            this.dspmct.Location = new System.Drawing.Point(466, 116);
            this.dspmct.Name = "dspmct";
            this.dspmct.Size = new System.Drawing.Size(183, 16);
            this.dspmct.TabIndex = 9;
            this.dspmct.Text = "Danh sách phiếu mượn chi tiết";
            // 
            // EditCTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dspmct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nhapspm);
            this.Controls.Add(this.nhapms);
            this.Controls.Add(this.nhapslm);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csctpm);
            this.Name = "EditCTPhieuMuon";
            this.Text = "Chỉnh sửa chi tiết phiếu mượn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label csctpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button xn;
        private System.Windows.Forms.TextBox nhapslm;
        private System.Windows.Forms.TextBox nhapms;
        private System.Windows.Forms.TextBox nhapspm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dspmct;
    }
}