namespace Bai2._4
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(68, 101);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(45, 13);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Ho ten: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(147, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(459, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(220, 179);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(152, 56);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hien Thi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 419);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbHoTen);
            this.Name = "Form1";
            this.Text = "Bai2.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnHienThi;
    }
}

