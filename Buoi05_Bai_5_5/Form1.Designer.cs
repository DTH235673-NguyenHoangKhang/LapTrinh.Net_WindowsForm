namespace BuoiTH5_Bai5
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
            this.txtMang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnMangNgauNhien = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnDemle = new System.Windows.Forms.Button();
            this.btnSumLe = new System.Windows.Forms.Button();
            this.btnSXLe = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc";
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(15, 29);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(523, 30);
            this.txtMang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKq);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(47, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(15, 29);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(529, 30);
            this.txtKq.TabIndex = 0;
            // 
            // btnMangNgauNhien
            // 
            this.btnMangNgauNhien.BackColor = System.Drawing.Color.Silver;
            this.btnMangNgauNhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangNgauNhien.Location = new System.Drawing.Point(47, 200);
            this.btnMangNgauNhien.Name = "btnMangNgauNhien";
            this.btnMangNgauNhien.Size = new System.Drawing.Size(272, 42);
            this.btnMangNgauNhien.TabIndex = 2;
            this.btnMangNgauNhien.Text = "Xuất mảng ngẫu nhiên";
            this.btnMangNgauNhien.UseVisualStyleBackColor = false;
            this.btnMangNgauNhien.Click += new System.EventHandler(this.btnMangNgauNhien_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Silver;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(325, 200);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(272, 42);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Tìm phần tử mảnh nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.BackColor = System.Drawing.Color.Silver;
            this.btnSXTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXTang.Location = new System.Drawing.Point(325, 296);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(272, 42);
            this.btnSXTang.TabIndex = 4;
            this.btnSXTang.Text = "Sắp xếp tăng";
            this.btnSXTang.UseVisualStyleBackColor = false;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnDemle
            // 
            this.btnDemle.BackColor = System.Drawing.Color.Silver;
            this.btnDemle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemle.Location = new System.Drawing.Point(47, 296);
            this.btnDemle.Name = "btnDemle";
            this.btnDemle.Size = new System.Drawing.Size(272, 42);
            this.btnDemle.TabIndex = 5;
            this.btnDemle.Text = "Đếm số phần tử lẻ";
            this.btnDemle.UseVisualStyleBackColor = false;
            this.btnDemle.Click += new System.EventHandler(this.btnDemle_Click);
            // 
            // btnSumLe
            // 
            this.btnSumLe.BackColor = System.Drawing.Color.Silver;
            this.btnSumLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumLe.Location = new System.Drawing.Point(47, 344);
            this.btnSumLe.Name = "btnSumLe";
            this.btnSumLe.Size = new System.Drawing.Size(272, 42);
            this.btnSumLe.TabIndex = 6;
            this.btnSumLe.Text = "Tổng phần tử lẻ";
            this.btnSumLe.UseVisualStyleBackColor = false;
            this.btnSumLe.Click += new System.EventHandler(this.btnSumLe_Click);
            // 
            // btnSXLe
            // 
            this.btnSXLe.BackColor = System.Drawing.Color.Silver;
            this.btnSXLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXLe.Location = new System.Drawing.Point(325, 344);
            this.btnSXLe.Name = "btnSXLe";
            this.btnSXLe.Size = new System.Drawing.Size(272, 42);
            this.btnSXLe.TabIndex = 8;
            this.btnSXLe.Text = "Sắp xếp giảm";
            this.btnSXLe.UseVisualStyleBackColor = false;
            this.btnSXLe.Click += new System.EventHandler(this.btnSXLe_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.BackColor = System.Drawing.Color.Silver;
            this.btnTang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang2.Location = new System.Drawing.Point(325, 248);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(272, 42);
            this.btnTang2.TabIndex = 9;
            this.btnTang2.Text = "Tăng mỗi pt mảng lên 2";
            this.btnTang2.UseVisualStyleBackColor = false;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Silver;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(47, 248);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(272, 42);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Tính tổng giá trị mảng";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 427);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnSXLe);
            this.Controls.Add(this.btnSumLe);
            this.Controls.Add(this.btnDemle);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMangNgauNhien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Working with Array";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnMangNgauNhien;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnDemle;
        private System.Windows.Forms.Button btnSumLe;
        private System.Windows.Forms.Button btnSXLe;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnSum;
    }
}

