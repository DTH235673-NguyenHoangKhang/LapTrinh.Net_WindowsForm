using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int chuvi=(int.Parse(txtA.Text) + int.Parse(txtB.Text)) * 2;
            txtKetQua.Text = chuvi.ToString();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int dientich = int.Parse(txtA.Text) * int.Parse(txtB.Text);
            txtKetQua.Text = dientich.ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double duongcheo = Math.Sqrt(Math.Pow(int.Parse(txtA.Text),2) + Math.Pow(int.Parse(txtB.Text), 2));
            txtKetQua.Text = duongcheo.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
