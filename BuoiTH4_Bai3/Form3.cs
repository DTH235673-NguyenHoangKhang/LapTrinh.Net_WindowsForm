using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH4_Bai3
{
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a)
        {
            InitializeComponent();
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);
            lblKQ.Text = "Phần tử lớn nhất trong mảng là " + TimMax().ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private int TimMax()
        {
            int max = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
                
            }
            return max;
        }
    }
}
