namespace Buoi06_Bai_1
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
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnDoiFont = new System.Windows.Forms.Button();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập đoạn văn bản:";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(71, 56);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(500, 148);
            this.txtKq.TabIndex = 1;
            // 
            // btnDoiFont
            // 
            this.btnDoiFont.AutoSize = true;
            this.btnDoiFont.Location = new System.Drawing.Point(71, 254);
            this.btnDoiFont.Name = "btnDoiFont";
            this.btnDoiFont.Size = new System.Drawing.Size(103, 39);
            this.btnDoiFont.TabIndex = 2;
            this.btnDoiFont.Text = "Đổi font";
            this.btnDoiFont.UseVisualStyleBackColor = true;
            this.btnDoiFont.Click += new System.EventHandler(this.btnDoiFont_Click);
            // 
            // btnChonMau
            // 
            this.btnChonMau.AutoSize = true;
            this.btnChonMau.Location = new System.Drawing.Point(204, 254);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(103, 39);
            this.btnChonMau.TabIndex = 3;
            this.btnChonMau.Text = "Chọn màu";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(468, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.Location = new System.Drawing.Point(335, 254);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 39);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(277, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 39);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 401);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChonMau);
            this.Controls.Add(this.btnDoiFont);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CommonDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnDoiFont;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnThoat;
    }
}

