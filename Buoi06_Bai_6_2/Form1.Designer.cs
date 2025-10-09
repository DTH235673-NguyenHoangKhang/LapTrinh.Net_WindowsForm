namespace Buoi06_Bai_2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLopB = new System.Windows.Forms.RadioButton();
            this.rdoLopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnAtoB = new System.Windows.Forms.Button();
            this.btnBtoA = new System.Windows.Forms.Button();
            this.btnBallA = new System.Windows.Forms.Button();
            this.btnAallB = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(456, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(691, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLopB);
            this.groupBox1.Controls.Add(this.rdoLopA);
            this.groupBox1.Location = new System.Drawing.Point(229, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(242, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp‎";
            // 
            // rdoLopB
            // 
            this.rdoLopB.AutoSize = true;
            this.rdoLopB.Location = new System.Drawing.Point(124, 46);
            this.rdoLopB.Name = "rdoLopB";
            this.rdoLopB.Size = new System.Drawing.Size(75, 24);
            this.rdoLopB.TabIndex = 1;
            this.rdoLopB.TabStop = true;
            this.rdoLopB.Text = "Lớp B";
            this.rdoLopB.UseVisualStyleBackColor = true;
            // 
            // rdoLopA
            // 
            this.rdoLopA.AutoSize = true;
            this.rdoLopA.Location = new System.Drawing.Point(22, 46);
            this.rdoLopA.Name = "rdoLopA";
            this.rdoLopA.Size = new System.Drawing.Size(74, 24);
            this.rdoLopA.TabIndex = 0;
            this.rdoLopA.TabStop = true;
            this.rdoLopA.Text = "Lớp A\r\n";
            this.rdoLopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopA);
            this.groupBox2.Location = new System.Drawing.Point(37, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 20;
            this.lstLopA.Location = new System.Drawing.Point(15, 27);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new System.Drawing.Size(239, 204);
            this.lstLopA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLopB);
            this.groupBox3.Location = new System.Drawing.Point(450, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 270);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 20;
            this.lstLopB.Location = new System.Drawing.Point(15, 26);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(239, 204);
            this.lstLopB.TabIndex = 1;
            // 
            // btnAtoB
            // 
            this.btnAtoB.AutoSize = true;
            this.btnAtoB.Location = new System.Drawing.Point(337, 250);
            this.btnAtoB.Name = "btnAtoB";
            this.btnAtoB.Size = new System.Drawing.Size(75, 30);
            this.btnAtoB.TabIndex = 6;
            this.btnAtoB.Text = ">";
            this.btnAtoB.UseVisualStyleBackColor = true;
            this.btnAtoB.Click += new System.EventHandler(this.btnAtoB_Click);
            // 
            // btnBtoA
            // 
            this.btnBtoA.AutoSize = true;
            this.btnBtoA.Location = new System.Drawing.Point(337, 286);
            this.btnBtoA.Name = "btnBtoA";
            this.btnBtoA.Size = new System.Drawing.Size(75, 30);
            this.btnBtoA.TabIndex = 7;
            this.btnBtoA.Text = "<";
            this.btnBtoA.UseVisualStyleBackColor = true;
            this.btnBtoA.Click += new System.EventHandler(this.btnBtoA_Click);
            // 
            // btnBallA
            // 
            this.btnBallA.AutoSize = true;
            this.btnBallA.Location = new System.Drawing.Point(337, 358);
            this.btnBallA.Name = "btnBallA";
            this.btnBallA.Size = new System.Drawing.Size(75, 30);
            this.btnBallA.TabIndex = 8;
            this.btnBallA.Text = "<<";
            this.btnBallA.UseVisualStyleBackColor = true;
            this.btnBallA.Click += new System.EventHandler(this.btnBallA_Click);
            // 
            // btnAallB
            // 
            this.btnAallB.AutoSize = true;
            this.btnAallB.Location = new System.Drawing.Point(337, 322);
            this.btnAallB.Name = "btnAallB";
            this.btnAallB.Size = new System.Drawing.Size(75, 30);
            this.btnAallB.TabIndex = 9;
            this.btnAallB.Text = ">>";
            this.btnAallB.UseVisualStyleBackColor = true;
            this.btnAallB.Click += new System.EventHandler(this.btnAallB_Click);
            // 
            // btnSum
            // 
            this.btnSum.AutoSize = true;
            this.btnSum.Location = new System.Drawing.Point(175, 497);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(150, 30);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Tổng số sinh viên";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(414, 497);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 562);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnAallB);
            this.Controls.Add(this.btnBallA);
            this.Controls.Add(this.btnBtoA);
            this.Controls.Add(this.btnAtoB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Danh sách sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLopB;
        private System.Windows.Forms.RadioButton rdoLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnAtoB;
        private System.Windows.Forms.Button btnBtoA;
        private System.Windows.Forms.Button btnBallA;
        private System.Windows.Forms.Button btnAallB;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnThoat;
    }
}

