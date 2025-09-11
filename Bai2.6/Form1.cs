using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            MessageBox.Show(tong.ToString());
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(txtA.Text) -int.Parse(txtB.Text);
            MessageBox.Show(hieu.ToString());
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(txtA.Text) * int.Parse(txtB.Text);
            MessageBox.Show(tich.ToString());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            float thuong = float.Parse(txtA.Text) / int.Parse(txtB.Text);
            MessageBox.Show(thuong.ToString());
        }
    }
}
