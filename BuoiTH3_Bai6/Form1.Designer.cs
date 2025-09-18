namespace BuoiTH3_Bai6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstKq = new System.Windows.Forms.ListBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnMauChu = new System.Windows.Forms.Button();
            this.btnMauNen = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapChuoi);
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(6, 35);
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(252, 26);
            this.txtNhapChuoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(173, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstKq
            // 
            this.lstKq.FormattingEnabled = true;
            this.lstKq.ItemHeight = 19;
            this.lstKq.Items.AddRange(new object[] {
            " "});
            this.lstKq.Location = new System.Drawing.Point(28, 184);
            this.lstKq.Name = "lstKq";
            this.lstKq.Size = new System.Drawing.Size(271, 80);
            this.lstKq.TabIndex = 3;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(337, 37);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(449, 110);
            this.txtKq.TabIndex = 4;
            // 
            // btnMauChu
            // 
            this.btnMauChu.Location = new System.Drawing.Point(337, 167);
            this.btnMauChu.Name = "btnMauChu";
            this.btnMauChu.Size = new System.Drawing.Size(122, 41);
            this.btnMauChu.TabIndex = 5;
            this.btnMauChu.Text = "Chọn màu chữ";
            this.btnMauChu.UseVisualStyleBackColor = true;
            this.btnMauChu.Click += new System.EventHandler(this.btnMauChu_Click);
            // 
            // btnMauNen
            // 
            this.btnMauNen.Location = new System.Drawing.Point(503, 167);
            this.btnMauNen.Name = "btnMauNen";
            this.btnMauNen.Size = new System.Drawing.Size(122, 41);
            this.btnMauNen.TabIndex = 6;
            this.btnMauNen.Text = "Chọn màu nền";
            this.btnMauNen.UseVisualStyleBackColor = true;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(664, 167);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(122, 41);
            this.btnPhong.TabIndex = 7;
            this.btnPhong.Text = "Chọn phông";
            this.btnPhong.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(502, 231);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(123, 33);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(899, 364);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnMauNen);
            this.Controls.Add(this.btnMauChu);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.lstKq);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstKq;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnMauChu;
        private System.Windows.Forms.Button btnMauNen;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDong;
    }
}

