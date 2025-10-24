using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi09_Bai_1
{
    public partial class Form2 : Form
    {
        public Form2(int check,int n)
        {
            InitializeComponent();
            if (check == 1)
                label1.Text = n + " là số hoàn hảo.";
            else
                label1.Text = n + " không phải là số hoàn hảo.";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
