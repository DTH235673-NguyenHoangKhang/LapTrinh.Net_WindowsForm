namespace BuoiTH5_Bai4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoHCN = new System.Windows.Forms.RadioButton();
            this.rdoHTG = new System.Windows.Forms.RadioButton();
            this.rdoHV = new System.Windows.Forms.RadioButton();
            this.rdoHT = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu Vi Và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(200, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình tròn - Hình vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(173, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình tam gác - Hình chữ nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHCN);
            this.groupBox1.Controls.Add(this.rdoHTG);
            this.groupBox1.Controls.Add(this.rdoHV);
            this.groupBox1.Controls.Add(this.rdoHT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(120, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdoHCN
            // 
            this.rdoHCN.AutoSize = true;
            this.rdoHCN.Location = new System.Drawing.Point(166, 79);
            this.rdoHCN.Name = "rdoHCN";
            this.rdoHCN.Size = new System.Drawing.Size(126, 24);
            this.rdoHCN.TabIndex = 3;
            this.rdoHCN.TabStop = true;
            this.rdoHCN.Text = "Hình chữ nhật";
            this.rdoHCN.UseVisualStyleBackColor = true;
            // 
            // rdoHTG
            // 
            this.rdoHTG.AutoSize = true;
            this.rdoHTG.Location = new System.Drawing.Point(166, 30);
            this.rdoHTG.Name = "rdoHTG";
            this.rdoHTG.Size = new System.Drawing.Size(124, 24);
            this.rdoHTG.TabIndex = 2;
            this.rdoHTG.TabStop = true;
            this.rdoHTG.Text = "Hình tam giác";
            this.rdoHTG.UseVisualStyleBackColor = true;
            // 
            // rdoHV
            // 
            this.rdoHV.AutoSize = true;
            this.rdoHV.Location = new System.Drawing.Point(24, 79);
            this.rdoHV.Name = "rdoHV";
            this.rdoHV.Size = new System.Drawing.Size(107, 24);
            this.rdoHV.TabIndex = 1;
            this.rdoHV.TabStop = true;
            this.rdoHV.Text = "Hình vuông";
            this.rdoHV.UseVisualStyleBackColor = true;
            // 
            // rdoHT
            // 
            this.rdoHT.AutoSize = true;
            this.rdoHT.Location = new System.Drawing.Point(24, 30);
            this.rdoHT.Name = "rdoHT";
            this.rdoHT.Size = new System.Drawing.Size(92, 24);
            this.rdoHT.TabIndex = 0;
            this.rdoHT.TabStop = true;
            this.rdoHT.Text = "Hình tròn";
            this.rdoHT.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(102, 299);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(86, 31);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(239, 299);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(371, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCV);
            this.groupBox2.Controls.Add(this.txtDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(144, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình tròn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bán kính: ";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(80, 47);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chu vi: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Diện tích: ";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(81, 126);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 20);
            this.txtDT.TabIndex = 4;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(80, 88);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(100, 20);
            this.txtCV.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính Chu Vi và Diện Tích";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHCN;
        private System.Windows.Forms.RadioButton rdoHTG;
        private System.Windows.Forms.RadioButton rdoHV;
        private System.Windows.Forms.RadioButton rdoHT;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label4;
    }
}

