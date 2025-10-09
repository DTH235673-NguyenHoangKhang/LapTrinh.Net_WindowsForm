using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtThang.Text) < 1 || int.Parse(txtThang.Text) > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            else if (int.Parse(txtThang.Text) > 1 || int.Parse(txtThang.Text) < 4)
            {
                MessageBox.Show("Mua xuan");
            }
            else if (int.Parse(txtThang.Text) >= 4 || int.Parse(txtThang.Text) < 7)
            {
                MessageBox.Show("Mua ha");
            }
            else if (int.Parse(txtThang.Text) >= 7 || int.Parse(txtThang.Text) < 10)
            {
                MessageBox.Show("Mua thu");
            }
            else
            {
                MessageBox.Show("Mua dong");
            }
        }
    }
}
