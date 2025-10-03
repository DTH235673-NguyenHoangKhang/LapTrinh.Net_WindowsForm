using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            string kq = "Mảng vừa nhập: ";
            for (int i = 0; i < b.Length; i++)
            {
                kq += b[i].ToString() + " ";
            }
            txtKq.Text = kq;
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtKq.Clear();
            txtMang.Clear();
            txtMang.Focus();
            txtSum.Clear();
            txtSumChan.Clear();
            txtSumLe.Clear();
            txtMax.Clear();
            txtMin.Clear();
            rdoSXT.Checked = false;
            rdoSXG.Checked = false;
            txtViTri.Clear();
            txtSo.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl=MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
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
            int sumle = 0;
            int sumchan = 0;
            for(int i = 0; i < b.Length; i++)
            {
                sum += b[i];
                if (b[i] % 2 == 0)
                    sumchan += b[i];
                else
                    sumle += b[i];
            }
            txtSum.Text = sum.ToString();
            txtSumChan.Text = sumchan.ToString();
            txtSumLe.Text = sumle.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int max = b[0];
            int min = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] > max)
                    max = b[i];
                if (b[i] < min)
                    min = b[i];
            }
            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnsapXep_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            if (rdoSXT.Checked == true)
            {
                Array.Sort(b);
                string kq = "Mảng sau khi sắp xếp tăng dần: ";
                for (int i = 0; i < b.Length; i++)
                {
                    kq += b[i].ToString() + " ";
                }
                txtKq.Text = kq;
            }
            else
            {
                Array.Sort(b);
                Array.Reverse(b);
                string kq = "Mảng sau khi sắp xếp giảm dần: ";
                for (int i = 0; i < b.Length; i++)
                {
                    kq += b[i].ToString() + " ";
                }
                txtKq.Text = kq;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = txtMang.Text.Split(' ');
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int so = int.Parse(txtSo.Text);
            int vt= int.Parse(txtViTri.Text);
            if (vt < 0 || vt >= b.Length)
            {
                MessageBox.Show("Vị trí không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                b[vt-1] = so;
                string kq = "Mảng sau khi thay thế: ";
                for (int i = 0; i < b.Length; i++)
                {
                    kq += b[i].ToString() + " ";
                }
                txtKq.Text = kq;
            }
        }
    }
}
