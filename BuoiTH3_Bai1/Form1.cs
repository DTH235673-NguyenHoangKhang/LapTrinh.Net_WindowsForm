using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Ten dang nhap la ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMat khau la ";
            thongbao += this.txtPass.Text;
            if(this.chkNho.Checked == true) 
                thongbao += "\n\rBan co ghi nho.";
            MessageBox.Show(thongbao, "Thong bao");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.chkNho.Checked = false;
            this.txtUser.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi=MessageBox.Show("Ban co muon dong chuong trinh khong?","Thong bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
                 Application.Exit();
        }
    }
}
