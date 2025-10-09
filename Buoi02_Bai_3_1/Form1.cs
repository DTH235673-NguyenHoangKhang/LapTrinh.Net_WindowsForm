using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(float.Parse(txtX.Text)>=2)
            {
                txtF.Text=(-8*Math.Pow(float.Parse(txtX.Text),3)-12*float.Parse(txtX.Text)-1).ToString();
            }
            else if(float.Parse(txtX.Text)>1)
            {
                txtF.Text = (Math.Pow(float.Parse(txtX.Text), 2) - 6 * float.Parse(txtX.Text) - 19).ToString();
            }
            else
            {
                txtF.Text=(7*Math.Pow(float.Parse(txtX.Text),2)).ToString();
            }
        }
    }
}
