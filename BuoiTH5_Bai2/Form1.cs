using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            string kq1 = "";
            string kq2 = "";
            int x = int.Parse(txtN.Text);
            if (CheckSHH(x) == 0)
            {
                kq1 = $"{x} không phải số hoàn hảo";
                MessageBox.Show(kq1, "Thông báo");
            }
            else
            {
                kq1 = $"{x} là số hoàn hảo";
                for (int i = 1; i < x; i++)
                    if (CheckSHH(i) == 1)
                        kq2 += i.ToString() + " ";
                MessageBox.Show(kq1 + $"\nCác số hoàn hảo nhỏ hơn {x}: " + kq2, "Thông báo");

            }
            txtN.Focus();
        }
        private int CheckSHH(int x)
        {
            int check = 0;
            int tong = 0;
            for (int i = 1; i < x; i++)
                if (x % i == 0)
                    tong += i;
            check= x==tong? 1 : 0;
            return check;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
