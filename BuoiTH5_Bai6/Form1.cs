using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoNhapXuat_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            string kq= "Mảng vừa nhập: ";
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
                kq += b[i].ToString() + " ";
            }
            txtKq.Text = kq;
        }

        private void rdoMin_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int min = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < min)
                    min = b[i];
            }
            txtKq.Text = "Phần tử nhỏ nhất trong mảng là: " + min.ToString();
        }

        private void rdoLietKeChan_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            string kq = "Các phần tử chẵn trong mảng: ";
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                    kq += b[i].ToString() + " ";
            }
            txtKq.Text = kq;
        }

        private void rdoChanCuoi_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int chanCuoi = -1;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i] % 2 == 0)
                {
                    chanCuoi = b[i];
                    break;
                }
            }
            txtKq.Text = chanCuoi != -1 ? "Phần tử chẵn cuối cùng trong mảng là: " + chanCuoi.ToString() : "Không có phần tử chẵn trong mảng.";
        }

        private void rdoTongLe_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int tongLe = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 0)
                    tongLe += b[i];
            }
            txtKq.Text = "Tổng các phần tử lẻ trong mảng là: " + tongLe.ToString();
        }

        private void rdoTongChan_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int tongChan = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                    tongChan += b[i];
            }
            txtKq.Text = "Tổng các phần tử chẵn trong mảng là: " + tongChan.ToString();
        }

        private void rdoDemLe_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int demLe = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 != 0)
                    demLe++;
            }
            txtKq.Text = "Số lượng phần tử lẻ trong mảng là: " + demLe.ToString();
        }

        private void rdoDemChan_CheckedChanged(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int demChan = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                    demChan++;
            }
            txtKq.Text = "Số lượng phần tử chẵn trong mảng là: " + demChan.ToString();
        }
    }
}
