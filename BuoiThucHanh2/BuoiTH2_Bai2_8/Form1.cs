using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong=int.Parse(txtA.Text)+int.Parse(txtB.Text);
            txtKetQua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu= int.Parse(txtA.Text) - int.Parse(txtB.Text);
            txtKetQua.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(txtA.Text) * int.Parse(txtB.Text);
            txtKetQua.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            float thuong = float.Parse(txtA.Text) / int.Parse(txtB.Text);
            txtKetQua.Text = thuong.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetQua.Enabled = false;
        }
    }
}
