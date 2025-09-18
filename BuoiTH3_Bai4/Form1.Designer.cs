namespace BuoiTH3_Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbChuthuong = new System.Windows.Forms.RadioButton();
            this.rdbChuhoa = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKq = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên: ";
            // 
            // txtNhapht
            // 
            this.txtNhapht.Location = new System.Drawing.Point(159, 30);
            this.txtNhapht.Name = "txtNhapht";
            this.txtNhapht.Size = new System.Drawing.Size(210, 26);
            this.txtNhapht.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn kiểu chữ";
            // 
            // rdbChuthuong
            // 
            this.rdbChuthuong.AutoSize = true;
            this.rdbChuthuong.Location = new System.Drawing.Point(114, 117);
            this.rdbChuthuong.Name = "rdbChuthuong";
            this.rdbChuthuong.Size = new System.Drawing.Size(100, 23);
            this.rdbChuthuong.TabIndex = 3;
            this.rdbChuthuong.TabStop = true;
            this.rdbChuthuong.Text = "Chữ thường";
            this.rdbChuthuong.UseVisualStyleBackColor = true;
            // 
            // rdbChuhoa
            // 
            this.rdbChuhoa.AutoSize = true;
            this.rdbChuhoa.Location = new System.Drawing.Point(114, 160);
            this.rdbChuhoa.Name = "rdbChuhoa";
            this.rdbChuhoa.Size = new System.Drawing.Size(120, 23);
            this.rdbChuhoa.TabIndex = 4;
            this.rdbChuhoa.TabStop = true;
            this.rdbChuhoa.Text = "CHỮ IN HOA";
            this.rdbChuhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(294, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(294, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(66, 224);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(75, 23);
            this.btnKq.TabIndex = 7;
            this.btnKq.Text = "Kết quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(159, 221);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(210, 26);
            this.txtKq.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.rdbChuhoa);
            this.Controls.Add(this.rdbChuthuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapht);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Đổi kiểu chữ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbChuthuong;
        private System.Windows.Forms.RadioButton rdbChuhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.TextBox txtKq;
    }
}

