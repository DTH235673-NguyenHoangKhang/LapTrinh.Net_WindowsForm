using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtN.Focus();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            string kq2 = "";
            int x = int.Parse(txtN.Text);
            if (CheckSNT(x) == 0)
            {
                txtKq1.Text = $"{x} không phải số nguyên tố";
                txtKq2.Text = kq2;
            }      
            else
            {
                txtKq1.Text = $"{x} là số nguyên tố";
                for (int i = 0; i < x; i++)
                    if (CheckSNT(i) == 1)
                        kq2 += i.ToString() + " ";
                txtKq2.Text = kq2;

            }    
                
            txtN.Focus();
        }
        private int CheckSNT(int x)
        {
            int check = 0;
            if (x < 2)
                return check;
            else
                for (int i = 2; i < x; i++)
                    if (x % i == 0)
                        return check;
            check = 1;
            return check;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      

       
       
    }
}
