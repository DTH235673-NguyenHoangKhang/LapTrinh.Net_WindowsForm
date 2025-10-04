using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ItemTong_Click(object sender, EventArgs e)
        {
            int a= int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a + b;
            txtKq.Text = kq.ToString();
        }

        private void ItemHieu_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a - b;
            txtKq.Text = kq.ToString();
        }

        private void ItemTich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int kq = a * b;
            txtKq.Text = kq.ToString();
        }

        private void ItemThuong_Click(object sender, EventArgs e)
        {
            float  a = float.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (b == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0");
            }
            else
            {
                float kq = Convert.ToSingle(a / b);
                txtKq.Text = kq.ToString();
            }
                
        }
    }
}
