using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float tong = 0;
            for (int i = 1; i <= 2*int.Parse(txtN.Text)+1; i++)
                if(i % 2 != 0)
                {
                tong += i;
                }
            txtS.Text = tong.ToString();
        }
    }
}
