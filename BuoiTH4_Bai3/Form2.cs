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
    public partial class Form2 : Form
    {
        int[] b;
        public Form2(int[] a)
        {
            InitializeComponent();
            b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            lblKQ.Text = "Tổng mảng = " + TongMang().ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            return sum;
        }
    }
}
