namespace BTL
{
    partial class EditThuThu
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
            this.ttt = new System.Windows.Forms.Label();
            this.mtt = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTenThuThu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.sdt = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Location = new System.Drawing.Point(95, 199);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(71, 16);
            this.ttt.TabIndex = 8;
            this.ttt.Text = "Tên thủ thư";
            // 
            // mtt
            // 
            this.mtt.AutoSize = true;
            this.mtt.Location = new System.Drawing.Point(95, 132);
            this.mtt.Name = "mtt";
            this.mtt.Size = new System.Drawing.Size(98, 16);
            this.mtt.TabIndex = 7;
            this.mtt.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(196, 129);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(100, 22);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtTenThuThu
            // 
            this.txtTenThuThu.Location = new System.Drawing.Point(196, 199);
            this.txtTenThuThu.Name = "txtTenThuThu";
            this.txtTenThuThu.Size = new System.Drawing.Size(100, 22);
            this.txtTenThuThu.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(491, 350);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 46);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.xn_Click);
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(434, 132);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(34, 16);
            this.sdt.TabIndex = 11;
            this.sdt.Text = "SĐT";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(434, 205);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(41, 16);
            this.e.TabIndex = 12;
            this.e.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(555, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(555, 132);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhâp thông tin cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quyền";
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(196, 268);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(100, 22);
            this.txtQuyen.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.e);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenThuThu);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.mtt);
            this.Controls.Add(this.ttt);
            this.Name = "EditThuThu";
            this.Text = "Chỉnh sửa thủ thư";
            this.Load += new System.EventHandler(this.EditThuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ttt;
        private System.Windows.Forms.Label mtt;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtTenThuThu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}