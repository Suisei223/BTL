﻿namespace BTL
{
    partial class EditSinhVien
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
            this.cssv = new System.Windows.Forms.Label();
            this.msv = new System.Windows.Forms.Label();
            this.tsv = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Label();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cssv
            // 
            this.cssv.AutoSize = true;
            this.cssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cssv.Location = new System.Drawing.Point(230, 24);
            this.cssv.Name = "cssv";
            this.cssv.Size = new System.Drawing.Size(262, 32);
            this.cssv.TabIndex = 0;
            this.cssv.Text = "Chỉnh sửa sinh viên";
            // 
            // msv
            // 
            this.msv.AutoSize = true;
            this.msv.Location = new System.Drawing.Point(143, 135);
            this.msv.Name = "msv";
            this.msv.Size = new System.Drawing.Size(81, 16);
            this.msv.TabIndex = 1;
            this.msv.Text = "Mã sinh viên";
            // 
            // tsv
            // 
            this.tsv.AutoSize = true;
            this.tsv.Location = new System.Drawing.Point(143, 197);
            this.tsv.Name = "tsv";
            this.tsv.Size = new System.Drawing.Size(86, 16);
            this.tsv.TabIndex = 2;
            this.tsv.Text = "Tên sinh viên";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(143, 271);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(34, 16);
            this.sdt.TabIndex = 3;
            this.sdt.Text = "SĐT";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(415, 197);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(30, 16);
            this.l.TabIndex = 4;
            this.l.Text = "Lớp";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(415, 271);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(41, 16);
            this.e.TabIndex = 5;
            this.e.Text = "Email";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(522, 346);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(412, 135);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(47, 16);
            this.n.TabIndex = 7;
            this.n.Text = "Ngành";
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(509, 129);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(100, 22);
            this.txtNganh.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(509, 191);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 22);
            this.txtLop.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(255, 132);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(255, 194);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(255, 271);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(509, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // EditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtNganh);
            this.Controls.Add(this.n);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.e);
            this.Controls.Add(this.l);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.tsv);
            this.Controls.Add(this.msv);
            this.Controls.Add(this.cssv);
            this.Name = "EditSinhVien";
            this.Text = "Chỉnh sửa sinh viên";
            this.Load += new System.EventHandler(this.EditSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cssv;
        private System.Windows.Forms.Label msv;
        private System.Windows.Forms.Label tsv;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
    }
}