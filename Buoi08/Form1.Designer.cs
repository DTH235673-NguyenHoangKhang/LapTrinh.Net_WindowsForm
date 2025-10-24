namespace Buoi08
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdoHinhVuong = new System.Windows.Forms.RadioButton();
            this.rdoHCN = new System.Windows.Forms.RadioButton();
            this.rdoHinhTron = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHinhTron);
            this.groupBox1.Controls.Add(this.rdoHCN);
            this.groupBox1.Controls.Add(this.rdoHinhVuong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(177, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÍNH DIỆN TÍCH VÀ CHU VI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBanKinh);
            this.groupBox2.Controls.Add(this.txtRong);
            this.groupBox2.Controls.Add(this.txtDai);
            this.groupBox2.Controls.Add(this.txtCanh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(192, 361);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(124, 34);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(420, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdoHinhVuong
            // 
            this.rdoHinhVuong.AutoSize = true;
            this.rdoHinhVuong.Location = new System.Drawing.Point(29, 29);
            this.rdoHinhVuong.Name = "rdoHinhVuong";
            this.rdoHinhVuong.Size = new System.Drawing.Size(132, 29);
            this.rdoHinhVuong.TabIndex = 0;
            this.rdoHinhVuong.TabStop = true;
            this.rdoHinhVuong.Text = "Hình vuông";
            this.rdoHinhVuong.UseVisualStyleBackColor = true;
            this.rdoHinhVuong.CheckedChanged += new System.EventHandler(this.rdoHinhVuong_CheckedChanged);
            // 
            // rdoHCN
            // 
            this.rdoHCN.AutoSize = true;
            this.rdoHCN.Location = new System.Drawing.Point(29, 70);
            this.rdoHCN.Name = "rdoHCN";
            this.rdoHCN.Size = new System.Drawing.Size(153, 29);
            this.rdoHCN.TabIndex = 1;
            this.rdoHCN.TabStop = true;
            this.rdoHCN.Text = "Hình chữ nhật";
            this.rdoHCN.UseVisualStyleBackColor = true;
            this.rdoHCN.CheckedChanged += new System.EventHandler(this.rdoHCN_CheckedChanged);
            // 
            // rdoHinhTron
            // 
            this.rdoHinhTron.AutoSize = true;
            this.rdoHinhTron.Location = new System.Drawing.Point(29, 115);
            this.rdoHinhTron.Name = "rdoHinhTron";
            this.rdoHinhTron.Size = new System.Drawing.Size(111, 29);
            this.rdoHinhTron.TabIndex = 2;
            this.rdoHinhTron.TabStop = true;
            this.rdoHinhTron.Text = "Hình tròn";
            this.rdoHinhTron.UseVisualStyleBackColor = true;
            this.rdoHinhTron.CheckedChanged += new System.EventHandler(this.rdoHinhTron_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cạnh: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dài: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rộng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bán kính R: ";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(102, 31);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(160, 30);
            this.txtCanh.TabIndex = 4;
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(68, 71);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(160, 30);
            this.txtDai.TabIndex = 5;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(300, 71);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(139, 30);
            this.txtRong.TabIndex = 6;
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(148, 119);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(160, 30);
            this.txtBanKinh.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bai tap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.RadioButton rdoHinhTron;
        private System.Windows.Forms.RadioButton rdoHCN;
        private System.Windows.Forms.RadioButton rdoHinhVuong;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtDai;
    }
}

