using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            if (this.txtNhapht.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtNhapht.Focus();
            }
            else
            {
                string hoten = this.txtNhapht.Text;
                if (this.rdbChuthuong.Checked == true)
                {
                    this.txtKq.Text = hoten.ToLower();
                }
                if (this.rdbChuhoa.Checked == true)
                {
                    this.txtKq.Text = hoten.ToUpper();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtNhapht.Clear();
            this.txtKq.Clear();
            this.txtNhapht.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi=MessageBox.Show("Bạn có muốn dừng chương trình không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi==DialogResult.OK)
                Application.Exit();
        }
    }
}
