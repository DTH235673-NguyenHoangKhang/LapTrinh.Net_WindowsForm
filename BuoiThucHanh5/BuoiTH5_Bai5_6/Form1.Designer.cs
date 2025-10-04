namespace BuoiTH5_Bai6
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.rdoNhapXuat = new System.Windows.Forms.RadioButton();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.rdoDemLe = new System.Windows.Forms.RadioButton();
            this.rdoTongChan = new System.Windows.Forms.RadioButton();
            this.rdoTongLe = new System.Windows.Forms.RadioButton();
            this.rdoChanCuoi = new System.Windows.Forms.RadioButton();
            this.rdoLietKeChan = new System.Windows.Forms.RadioButton();
            this.rdoDemChan = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKq);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(67, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(15, 29);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(523, 30);
            this.txtKq.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 67);
            this.groupBox1.TabIndex = 2;
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
            // rdoNhapXuat
            // 
            this.rdoNhapXuat.AutoSize = true;
            this.rdoNhapXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhapXuat.Location = new System.Drawing.Point(67, 207);
            this.rdoNhapXuat.Name = "rdoNhapXuat";
            this.rdoNhapXuat.Size = new System.Drawing.Size(237, 33);
            this.rdoNhapXuat.TabIndex = 4;
            this.rdoNhapXuat.TabStop = true;
            this.rdoNhapXuat.Text = "Nhập và xuất mảng";
            this.rdoNhapXuat.UseVisualStyleBackColor = true;
            this.rdoNhapXuat.CheckedChanged += new System.EventHandler(this.rdoNhapXuat_CheckedChanged);
            // 
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMin.Location = new System.Drawing.Point(374, 207);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.Size = new System.Drawing.Size(238, 33);
            this.rdoMin.TabIndex = 5;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "Tìm giá trị nhỏ nhất";
            this.rdoMin.UseVisualStyleBackColor = true;
            this.rdoMin.CheckedChanged += new System.EventHandler(this.rdoMin_CheckedChanged);
            // 
            // rdoDemLe
            // 
            this.rdoDemLe.AutoSize = true;
            this.rdoDemLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDemLe.Location = new System.Drawing.Point(67, 356);
            this.rdoDemLe.Name = "rdoDemLe";
            this.rdoDemLe.Size = new System.Drawing.Size(195, 33);
            this.rdoDemLe.TabIndex = 6;
            this.rdoDemLe.TabStop = true;
            this.rdoDemLe.Text = "Đếm phần tử lẻ";
            this.rdoDemLe.UseVisualStyleBackColor = true;
            this.rdoDemLe.CheckedChanged += new System.EventHandler(this.rdoDemLe_CheckedChanged);
            // 
            // rdoTongChan
            // 
            this.rdoTongChan.AutoSize = true;
            this.rdoTongChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTongChan.Location = new System.Drawing.Point(374, 304);
            this.rdoTongChan.Name = "rdoTongChan";
            this.rdoTongChan.Size = new System.Drawing.Size(297, 33);
            this.rdoTongChan.TabIndex = 7;
            this.rdoTongChan.TabStop = true;
            this.rdoTongChan.Text = "Tổng phần tử giá trị chẵn";
            this.rdoTongChan.UseVisualStyleBackColor = true;
            this.rdoTongChan.CheckedChanged += new System.EventHandler(this.rdoTongChan_CheckedChanged);
            // 
            // rdoTongLe
            // 
            this.rdoTongLe.AutoSize = true;
            this.rdoTongLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTongLe.Location = new System.Drawing.Point(67, 304);
            this.rdoTongLe.Name = "rdoTongLe";
            this.rdoTongLe.Size = new System.Drawing.Size(266, 33);
            this.rdoTongLe.TabIndex = 8;
            this.rdoTongLe.TabStop = true;
            this.rdoTongLe.Text = "Tổng phần tử giá trị lẻ";
            this.rdoTongLe.UseVisualStyleBackColor = true;
            this.rdoTongLe.CheckedChanged += new System.EventHandler(this.rdoTongLe_CheckedChanged);
            // 
            // rdoChanCuoi
            // 
            this.rdoChanCuoi.AutoSize = true;
            this.rdoChanCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChanCuoi.Location = new System.Drawing.Point(374, 256);
            this.rdoChanCuoi.Name = "rdoChanCuoi";
            this.rdoChanCuoi.Size = new System.Drawing.Size(326, 33);
            this.rdoChanCuoi.TabIndex = 9;
            this.rdoChanCuoi.TabStop = true;
            this.rdoChanCuoi.Text = "Tìm phần tử chẵn cuối cùng";
            this.rdoChanCuoi.UseVisualStyleBackColor = true;
            this.rdoChanCuoi.CheckedChanged += new System.EventHandler(this.rdoChanCuoi_CheckedChanged);
            // 
            // rdoLietKeChan
            // 
            this.rdoLietKeChan.AutoSize = true;
            this.rdoLietKeChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLietKeChan.Location = new System.Drawing.Point(67, 256);
            this.rdoLietKeChan.Name = "rdoLietKeChan";
            this.rdoLietKeChan.Size = new System.Drawing.Size(289, 33);
            this.rdoLietKeChan.TabIndex = 10;
            this.rdoLietKeChan.TabStop = true;
            this.rdoLietKeChan.Text = "Liệt kê các phần tử chẵn";
            this.rdoLietKeChan.UseVisualStyleBackColor = true;
            this.rdoLietKeChan.CheckedChanged += new System.EventHandler(this.rdoLietKeChan_CheckedChanged);
            // 
            // rdoDemChan
            // 
            this.rdoDemChan.AutoSize = true;
            this.rdoDemChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDemChan.Location = new System.Drawing.Point(374, 356);
            this.rdoDemChan.Name = "rdoDemChan";
            this.rdoDemChan.Size = new System.Drawing.Size(226, 33);
            this.rdoDemChan.TabIndex = 11;
            this.rdoDemChan.TabStop = true;
            this.rdoDemChan.Text = "Đếm phần tử chẵn";
            this.rdoDemChan.UseVisualStyleBackColor = true;
            this.rdoDemChan.CheckedChanged += new System.EventHandler(this.rdoDemChan_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoDemChan);
            this.Controls.Add(this.rdoLietKeChan);
            this.Controls.Add(this.rdoChanCuoi);
            this.Controls.Add(this.rdoTongLe);
            this.Controls.Add(this.rdoTongChan);
            this.Controls.Add(this.rdoDemLe);
            this.Controls.Add(this.rdoMin);
            this.Controls.Add(this.rdoNhapXuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.RadioButton rdoNhapXuat;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.RadioButton rdoDemLe;
        private System.Windows.Forms.RadioButton rdoTongChan;
        private System.Windows.Forms.RadioButton rdoTongLe;
        private System.Windows.Forms.RadioButton rdoChanCuoi;
        private System.Windows.Forms.RadioButton rdoLietKeChan;
        private System.Windows.Forms.RadioButton rdoDemChan;
    }
}

