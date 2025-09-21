namespace BuoiTH3_Bai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tínhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTong = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemHieu = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTich = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemThuong = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phép toán đơn giản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(144, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(62, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(184, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(62, 44);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(184, 22);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả: ";
            // 
            // txtKq
            // 
            this.txtKq.Enabled = false;
            this.txtKq.Location = new System.Drawing.Point(205, 299);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(203, 22);
            this.txtKq.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tínhToánToolStripMenuItem
            // 
            this.tínhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTong,
            this.ItemHieu,
            this.ItemTich,
            this.ItemThuong});
            this.tínhToánToolStripMenuItem.Name = "tínhToánToolStripMenuItem";
            this.tínhToánToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tínhToánToolStripMenuItem.Text = "Tính toán";
            // 
            // ItemTong
            // 
            this.ItemTong.Name = "ItemTong";
            this.ItemTong.Size = new System.Drawing.Size(224, 26);
            this.ItemTong.Text = "Tổng";
            this.ItemTong.Click += new System.EventHandler(this.ItemTong_Click);
            // 
            // ItemHieu
            // 
            this.ItemHieu.Name = "ItemHieu";
            this.ItemHieu.Size = new System.Drawing.Size(224, 26);
            this.ItemHieu.Text = "Hiệu";
            this.ItemHieu.Click += new System.EventHandler(this.ItemHieu_Click);
            // 
            // ItemTich
            // 
            this.ItemTich.Name = "ItemTich";
            this.ItemTich.Size = new System.Drawing.Size(224, 26);
            this.ItemTich.Text = "Tích";
            this.ItemTich.Click += new System.EventHandler(this.ItemTich_Click);
            // 
            // ItemThuong
            // 
            this.ItemThuong.Name = "ItemThuong";
            this.ItemThuong.Size = new System.Drawing.Size(224, 26);
            this.ItemThuong.Text = "Thương";
            this.ItemThuong.Click += new System.EventHandler(this.ItemThuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 474);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Bai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tínhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemTong;
        private System.Windows.Forms.ToolStripMenuItem ItemHieu;
        private System.Windows.Forms.ToolStripMenuItem ItemTich;
        private System.Windows.Forms.ToolStripMenuItem ItemThuong;
    }
}

