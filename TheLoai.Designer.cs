namespace BTL
{
    partial class TheLoai
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
            this.nttls = new System.Windows.Forms.Label();
            this.ttl = new System.Windows.Forms.Label();
            this.xn = new System.Windows.Forms.Button();
            this.nhapttl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dstl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nttls
            // 
            this.nttls.AutoSize = true;
            this.nttls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nttls.Location = new System.Drawing.Point(197, 32);
            this.nttls.Name = "nttls";
            this.nttls.Size = new System.Drawing.Size(319, 32);
            this.nttls.TabIndex = 0;
            this.nttls.Text = "Nhập thêm thể loại sách";
            // 
            // ttl
            // 
            this.ttl.AutoSize = true;
            this.ttl.Location = new System.Drawing.Point(109, 163);
            this.ttl.Name = "ttl";
            this.ttl.Size = new System.Drawing.Size(77, 16);
            this.ttl.TabIndex = 1;
            this.ttl.Text = "Tên thể loại";
            // 
            // xn
            // 
            this.xn.Location = new System.Drawing.Point(341, 370);
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(75, 23);
            this.xn.TabIndex = 3;
            this.xn.Text = "Xác nhận";
            this.xn.UseVisualStyleBackColor = true;
            // 
            // nhapttl
            // 
            this.nhapttl.Location = new System.Drawing.Point(242, 160);
            this.nhapttl.Name = "nhapttl";
            this.nhapttl.Size = new System.Drawing.Size(100, 22);
            this.nhapttl.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dstl
            // 
            this.dstl.AutoSize = true;
            this.dstl.Location = new System.Drawing.Point(482, 116);
            this.dstl.Name = "dstl";
            this.dstl.Size = new System.Drawing.Size(117, 16);
            this.dstl.TabIndex = 5;
            this.dstl.Text = "Danh sách thể loại";
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dstl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nhapttl);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.ttl);
            this.Controls.Add(this.nttls);
            this.Name = "TheLoai";
            this.Text = "Thể loại";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nttls;
        private System.Windows.Forms.Label ttl;
        private System.Windows.Forms.Button xn;
        private System.Windows.Forms.TextBox nhapttl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dstl;
    }
}