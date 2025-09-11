namespace Bai2._10
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnDuongCheo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HINH CHU NHAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(171, 110);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(256, 20);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(171, 175);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(256, 20);
            this.txtB.TabIndex = 4;
            // 
            // btnChuVi
            // 
            this.btnChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuVi.Location = new System.Drawing.Point(39, 308);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(112, 51);
            this.btnChuVi.TabIndex = 5;
            this.btnChuVi.Text = "Chu Vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienTich.Location = new System.Drawing.Point(171, 308);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(112, 51);
            this.btnDienTich.TabIndex = 6;
            this.btnDienTich.Text = "Dien Tich";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnDuongCheo
            // 
            this.btnDuongCheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuongCheo.Location = new System.Drawing.Point(301, 308);
            this.btnDuongCheo.Name = "btnDuongCheo";
            this.btnDuongCheo.Size = new System.Drawing.Size(158, 51);
            this.btnDuongCheo.TabIndex = 7;
            this.btnDuongCheo.Text = "Duong cheo";
            this.btnDuongCheo.UseVisualStyleBackColor = true;
            this.btnDuongCheo.Click += new System.EventHandler(this.btnDuongCheo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(476, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 51);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 393);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDuongCheo);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai2.10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnDuongCheo;
        private System.Windows.Forms.Button btnThoat;
    }
}

