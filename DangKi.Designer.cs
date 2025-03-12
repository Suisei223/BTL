namespace BTL
{
    partial class DangKi
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
            this.dk = new System.Windows.Forms.Label();
            this.tk = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.Label();
            this.xnmk = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.rdoSinhVien = new System.Windows.Forms.RadioButton();
            this.rdoThuThu = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dk
            // 
            this.dk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dk.AutoSize = true;
            this.dk.Location = new System.Drawing.Point(347, 65);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(109, 16);
            this.dk.TabIndex = 10;
            this.dk.Text = "Đăng kí tài khoản";
            // 
            // tk
            // 
            this.tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tk.AutoSize = true;
            this.tk.Location = new System.Drawing.Point(116, 155);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(67, 16);
            this.tk.TabIndex = 10;
            this.tk.Text = "Tài khoản";
            // 
            // mk
            // 
            this.mk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mk.AutoSize = true;
            this.mk.Location = new System.Drawing.Point(116, 212);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(61, 16);
            this.mk.TabIndex = 10;
            this.mk.Text = "Mật khẩu";
            // 
            // xnmk
            // 
            this.xnmk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xnmk.AutoSize = true;
            this.xnmk.Location = new System.Drawing.Point(116, 272);
            this.xnmk.Name = "xnmk";
            this.xnmk.Size = new System.Drawing.Size(119, 16);
            this.xnmk.TabIndex = 10;
            this.xnmk.Text = "Xác nhận mật khẩu";
            // 
            // cv
            // 
            this.cv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(116, 327);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(54, 16);
            this.cv.TabIndex = 10;
            this.cv.Text = "Chức vụ";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.Location = new System.Drawing.Point(613, 363);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(118, 51);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(281, 152);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(275, 22);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Location = new System.Drawing.Point(281, 206);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(275, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(281, 266);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(275, 22);
            this.txtXacNhanMatKhau.TabIndex = 3;
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoSinhVien.AutoSize = true;
            this.rdoSinhVien.Location = new System.Drawing.Point(281, 327);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(82, 20);
            this.rdoSinhVien.TabIndex = 11;
            this.rdoSinhVien.TabStop = true;
            this.rdoSinhVien.Text = "Sinh viên";
            this.rdoSinhVien.UseVisualStyleBackColor = true;
            // 
            // rdoThuThu
            // 
            this.rdoThuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoThuThu.AutoSize = true;
            this.rdoThuThu.Location = new System.Drawing.Point(456, 327);
            this.rdoThuThu.Name = "rdoThuThu";
            this.rdoThuThu.Size = new System.Drawing.Size(71, 20);
            this.rdoThuThu.TabIndex = 12;
            this.rdoThuThu.TabStop = true;
            this.rdoThuThu.Text = "Thủ thư";
            this.rdoThuThu.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoThuThu);
            this.Controls.Add(this.rdoSinhVien);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.xnmk);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.dk);
            this.Name = "DangKi";
            this.Text = "Đăng kí tài khoản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dk;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.Label mk;
        private System.Windows.Forms.Label xnmk;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.RadioButton rdoSinhVien;
        private System.Windows.Forms.RadioButton rdoThuThu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}