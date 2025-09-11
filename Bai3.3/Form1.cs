using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtThang.Text) < 1 || int.Parse(txtThang.Text) > 12)
            {
                MessageBox.Show("Ngay khong hop le!");
                return;
            }
            if (int.Parse(txtThang.Text) == 4 || int.Parse(txtThang.Text) == 6 || int.Parse(txtThang.Text) == 9 || int.Parse(txtThang.Text) == 12)
                if (int.Parse(txtNgay.Text) > 30)
                {
                    MessageBox.Show("Ngay khong hop le!");
                    return;
                }
            if (int.Parse(txtThang.Text) == 2)
                if (int.Parse(txtNgay.Text) > 29)
                {
                    MessageBox.Show("Ngay khong hop le!");
                    return;
                }
            if (int.Parse(txtThang.Text) == 2 &&  int.Parse(txtNam.Text) % 4 != 0)
                if (int.Parse(txtNgay.Text) > 28)
                {
                    MessageBox.Show("Ngay khong hop le!");
                    return;
                }
            if (int.Parse(txtThang.Text) < 1 || int.Parse(txtNgay.Text) < 1 || int.Parse(txtNam.Text) < 1)
            {
                MessageBox.Show("Ngay khong hop le!");
                return;
            }
            MessageBox.Show("Ngay hop le!");
        }
    }
}
