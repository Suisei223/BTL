namespace BTL
{
    partial class EditSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cs = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            this.xn = new System.Windows.Forms.Button();
            this.dssdc = new System.Windows.Forms.Label();
            this.nhapts = new System.Windows.Forms.TextBox();
            this.nhapms = new System.Windows.Forms.TextBox();
            this.nhaptl = new System.Windows.Forms.TextBox();
            this.nhapsl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(244, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs.Location = new System.Drawing.Point(261, 27);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(175, 29);
            this.cs.TabIndex = 1;
            this.cs.Text = "Chỉnh sửa sách";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(352, 130);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(58, 16);
            this.ms.TabIndex = 2;
            this.ms.Text = "Mã sách";
            // 
            // ts
            // 
            this.ts.AutoSize = true;
            this.ts.Location = new System.Drawing.Point(581, 130);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(63, 16);
            this.ts.TabIndex = 3;
            this.ts.Text = "Tên sách";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.Location = new System.Drawing.Point(352, 198);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(56, 16);
            this.tl.TabIndex = 4;
            this.tl.Text = "Thể loại";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(584, 198);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(60, 16);
            this.sl.TabIndex = 5;
            this.sl.Text = "Số lượng";
            // 
            // xn
            // 
            this.xn.Location = new System.Drawing.Point(629, 388);
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(75, 23);
            this.xn.TabIndex = 5;
            this.xn.Text = "Xác nhận";
            this.xn.UseVisualStyleBackColor = true;
            // 
            // dssdc
            // 
            this.dssdc.AutoSize = true;
            this.dssdc.Location = new System.Drawing.Point(26, 81);
            this.dssdc.Name = "dssdc";
            this.dssdc.Size = new System.Drawing.Size(140, 16);
            this.dssdc.TabIndex = 8;
            this.dssdc.Text = "Danh sách sách đã có";
            // 
            // nhapts
            // 
            this.nhapts.Location = new System.Drawing.Point(688, 127);
            this.nhapts.Name = "nhapts";
            this.nhapts.Size = new System.Drawing.Size(100, 22);
            this.nhapts.TabIndex = 2;
            // 
            // nhapms
            // 
            this.nhapms.Location = new System.Drawing.Point(446, 124);
            this.nhapms.Name = "nhapms";
            this.nhapms.Size = new System.Drawing.Size(100, 22);
            this.nhapms.TabIndex = 1;
            // 
            // nhaptl
            // 
            this.nhaptl.Location = new System.Drawing.Point(446, 192);
            this.nhaptl.Name = "nhaptl";
            this.nhaptl.Size = new System.Drawing.Size(100, 22);
            this.nhaptl.TabIndex = 3;
            // 
            // nhapsl
            // 
            this.nhapsl.Location = new System.Drawing.Point(688, 198);
            this.nhapsl.Name = "nhapsl";
            this.nhapsl.Size = new System.Drawing.Size(100, 22);
            this.nhapsl.TabIndex = 4;
            // 
            // EditSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nhapsl);
            this.Controls.Add(this.nhaptl);
            this.Controls.Add(this.nhapms);
            this.Controls.Add(this.nhapts);
            this.Controls.Add(this.dssdc);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditSach";
            this.Text = "Chỉnh sửa sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cs;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Label ts;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.Button xn;
        private System.Windows.Forms.Label dssdc;
        private System.Windows.Forms.TextBox nhapts;
        private System.Windows.Forms.TextBox nhapms;
        private System.Windows.Forms.TextBox nhaptl;
        private System.Windows.Forms.TextBox nhapsl;
    }
}