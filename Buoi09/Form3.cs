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
    public partial class Form3 : Form
    {
        public Form3(int n)
        {
            InitializeComponent();
            Random rd = new Random();
            string s = "";
            string sochan= "";
            for (int i = 0; i < n; i++)
            {
                int so = rd.Next(n, n + 12);
                s += so.ToString() + " ";
                if(so % 2 == 0)
                {
                    sochan += so.ToString() + " ";
                }
            }
            txtPhanTu.Text = s;
            txtSoChan.Text = sochan;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
