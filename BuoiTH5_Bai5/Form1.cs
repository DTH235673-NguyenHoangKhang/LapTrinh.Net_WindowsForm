using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMangNgauNhien_Click(object sender, EventArgs e)
        {
            string kq= "Mảng ngẫu nhiên: ";
            string[] a= txtMang.Text.Split(' ');
            
            Random rd = new Random();
            int n=rd.Next(0, a.Length);
            for(int i=0;i<n;i++)
            {
                kq += a[rd.Next(0,a.Length)] + " ";
            }
            txtKq.Text = kq;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            string[] a=txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int min = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < min) min = b[i];
            }
            txtKq.Text = "Phần tử nhỏ nhất là: " + min;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            txtKq.Text = "Tổng các phần tử là: " + sum;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i])+2;
            }
            string kq = "";
            for (int i = 0; i < b.Length; i++)
            {
                kq += b[i].ToString()+" ";
            }
            txtKq.Text = "Tổng các phần tử là: " + kq;
        }

        private void btnDemle_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int demle = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 0) demle++;
            }
            txtKq.Text = "Số lượng các phần tử lẻ là: " + demle;
        }

        private void btnSumLe_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int sumle = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 0) sumle += b[i]; 
            }
            txtKq.Text = "Tổng các phần tử là: " + sumle;
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            Array.Sort(b);
            string kq = "";
            for (int i = 0; i < b.Length; i++)
            {
                kq += b[i].ToString() + " ";
            }
            txtKq.Text = "Mảng sau khi sắp xếp tăng dần: " + kq;
        }

        private void btnSXLe_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            Array.Sort(b);
            Array.Reverse(b);
            string kq = "";
            for (int i = 0; i < b.Length; i++)
            {
                kq += b[i].ToString() + " ";
            }
            txtKq.Text = "Mảng sau khi sắp xếp giảm dần: " + kq;
        }
    }
}
