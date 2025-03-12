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
            this.tctt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ttsv = new System.Windows.Forms.Button();
            this.tttt = new System.Windows.Forms.Button();
            this.cssv = new System.Windows.Forms.Button();
            this.cstt = new System.Windows.Forms.Button();
            this.css = new System.Windows.Forms.Button();
            this.csp = new System.Windows.Forms.Button();
            this.ttpm = new System.Windows.Forms.Button();
            this.ttk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tctt
            // 
            this.tctt.AutoSize = true;
            this.tctt.Location = new System.Drawing.Point(306, 23);
            this.tctt.Name = "tctt";
            this.tctt.Size = new System.Drawing.Size(107, 16);
            this.tctt.TabIndex = 0;
            this.tctt.Text = "Trang chủ thủ thư";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // ttsv
            // 
            this.ttsv.Location = new System.Drawing.Point(110, 320);
            this.ttsv.Name = "ttsv";
            this.ttsv.Size = new System.Drawing.Size(75, 42);
            this.ttsv.TabIndex = 2;
            this.ttsv.Text = "Thông tin sinh viên";
            this.ttsv.UseVisualStyleBackColor = true;
            // 
            // tttt
            // 
            this.tttt.Location = new System.Drawing.Point(110, 385);
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(75, 41);
            this.tttt.TabIndex = 3;
            this.tttt.Text = "Thông tin thủ thư ";
            this.tttt.UseVisualStyleBackColor = true;
            // 
            // cssv
            // 
            this.cssv.Location = new System.Drawing.Point(263, 320);
            this.cssv.Name = "cssv";
            this.cssv.Size = new System.Drawing.Size(75, 42);
            this.cssv.TabIndex = 4;
            this.cssv.Text = "Chỉnh sửa sinh viên";
            this.cssv.UseVisualStyleBackColor = true;
            // 
            // cstt
            // 
            this.cstt.Location = new System.Drawing.Point(263, 385);
            this.cstt.Name = "cstt";
            this.cstt.Size = new System.Drawing.Size(75, 41);
            this.cstt.TabIndex = 5;
            this.cstt.Text = "Chỉnh sửa thủ thư";
            this.cstt.UseVisualStyleBackColor = true;
            // 
            // css
            // 
            this.css.Location = new System.Drawing.Point(414, 320);
            this.css.Name = "css";
            this.css.Size = new System.Drawing.Size(81, 42);
            this.css.TabIndex = 6;
            this.css.Text = "Chỉnh sửa sách";
            this.css.UseVisualStyleBackColor = true;
            // 
            // csp
            // 
            this.csp.Location = new System.Drawing.Point(414, 385);
            this.csp.Name = "csp";
            this.csp.Size = new System.Drawing.Size(81, 41);
            this.csp.TabIndex = 7;
            this.csp.Text = "Chỉnh sửa phiếu mượn";
            this.csp.UseVisualStyleBackColor = true;
            // 
            // ttpm
            // 
            this.ttpm.Location = new System.Drawing.Point(557, 320);
            this.ttpm.Name = "ttpm";
            this.ttpm.Size = new System.Drawing.Size(86, 42);
            this.ttpm.TabIndex = 8;
            this.ttpm.Text = "Thông tin phiếu mượn";
            this.ttpm.UseVisualStyleBackColor = true;
            // 
            // ttk
            // 
            this.ttk.Location = new System.Drawing.Point(557, 385);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(86, 41);
            this.ttk.TabIndex = 9;
            this.ttk.Text = "Thoát tài khoản";
            this.ttk.UseVisualStyleBackColor = true;
            // 
            // TrangChuThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.ttpm);
            this.Controls.Add(this.csp);
            this.Controls.Add(this.css);
            this.Controls.Add(this.cstt);
            this.Controls.Add(this.cssv);
            this.Controls.Add(this.tttt);
            this.Controls.Add(this.ttsv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tctt);
            this.Name = "TrangChuThuThu";
            this.Text = "TrangChuThuThu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tctt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ttsv;
        private System.Windows.Forms.Button tttt;
        private System.Windows.Forms.Button cssv;
        private System.Windows.Forms.Button cstt;
        private System.Windows.Forms.Button css;
        private System.Windows.Forms.Button csp;
        private System.Windows.Forms.Button ttpm;
        private System.Windows.Forms.Button ttk;
    }
}