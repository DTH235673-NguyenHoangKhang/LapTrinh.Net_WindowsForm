using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float gt =1;
            for (int i = 1; i <= int.Parse(txtN.Text); i++)
                {
                    gt = gt * i;
                }
            txtS.Text = gt.ToString();
        }
    }
}
