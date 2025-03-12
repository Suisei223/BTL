namespace BTL
{
    partial class DangNhap
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
            this.dntk = new System.Windows.Forms.Label();
            this.tk = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.Label();
            this.dk = new System.Windows.Forms.Button();
            this.dn = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dntk
            // 
            this.dntk.AutoSize = true;
            this.dntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dntk.Location = new System.Drawing.Point(236, 26);
            this.dntk.Name = "dntk";
            this.dntk.Size = new System.Drawing.Size(231, 29);
            this.dntk.TabIndex = 0;
            this.dntk.Text = "Đăng nhập tài khoản";
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Location = new System.Drawing.Point(121, 157);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(67, 16);
            this.tk.TabIndex = 0;
            this.tk.Text = "Tài khoản";
            // 
            // mk
            // 
            this.mk.AutoSize = true;
            this.mk.Location = new System.Drawing.Point(121, 233);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(61, 16);
            this.mk.TabIndex = 0;
            this.mk.Text = "Mật khẩu";
            // 
            // dk
            // 
            this.dk.Location = new System.Drawing.Point(241, 331);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(95, 44);
            this.dk.TabIndex = 3;
            this.dk.Text = "Đăng kí";
            this.dk.UseVisualStyleBackColor = true;
            this.dk.Click += new System.EventHandler(this.dk_Click);
            // 
            // dn
            // 
            this.dn.Location = new System.Drawing.Point(480, 330);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(96, 44);
            this.dn.TabIndex = 4;
            this.dn.Text = "Đăng nhập";
            this.dn.UseVisualStyleBackColor = true;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(241, 227);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(100, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(241, 154);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(100, 22);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.dntk);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dntk;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.Label mk;
        private System.Windows.Forms.Button dk;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

