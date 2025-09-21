namespace BuoiTH3_Bai8
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
            this.CboTen = new System.Windows.Forms.ComboBox();
            this.btnChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // CboTen
            // 
            this.CboTen.FormattingEnabled = true;
            this.CboTen.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Trần Văn C",
            "Lý Thị D"});
            this.CboTen.Location = new System.Drawing.Point(229, 114);
            this.CboTen.Name = "CboTen";
            this.CboTen.Size = new System.Drawing.Size(288, 24);
            this.CboTen.TabIndex = 1;
            // 
            // btnChao
            // 
            this.btnChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChao.Location = new System.Drawing.Point(229, 218);
            this.btnChao.Name = "btnChao";
            this.btnChao.Size = new System.Drawing.Size(228, 39);
            this.btnChao.TabIndex = 2;
            this.btnChao.Text = "Hiện lời chào";
            this.btnChao.UseVisualStyleBackColor = true;
            this.btnChao.Click += new System.EventHandler(this.btnChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChao);
            this.Controls.Add(this.CboTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTen;
        private System.Windows.Forms.Button btnChao;
    }
}

