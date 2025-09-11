using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double Delta=Math.Pow(float.Parse(txtB.Text), 2) - 4 * float.Parse(txtA.Text) * float.Parse(txtC.Text); 
            double CanDelta = Math.Sqrt(Delta);
            if(int.Parse(txtA.Text) == 0 )
            {
                MessageBox.Show("Hệ số a phải khác 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Delta < 0)
            {
                txtKetQua.Text="Phương trình vô nghiệm";
            }
            else if (Delta == 0)
            {
                float x = -float.Parse(txtB.Text) / (2 * float.Parse(txtA.Text));
                txtKetQua.Text = ("Phương trình có nghiệm kép: x1 = x2 = " + x.ToString());
            }
            else
            {
                float x1 = (float)(-float.Parse(txtB.Text) + CanDelta) / (2 * float.Parse(txtA.Text));
                float x2 = (float)(-float.Parse(txtB.Text) - CanDelta) / (2 * float.Parse(txtA.Text));
                txtKetQua.Text = ("Phương trình có hai nghiệm phân biệt: x1 = " + x1.ToString() + ", x2 = " + x2.ToString());
            }
        }
    }
}
