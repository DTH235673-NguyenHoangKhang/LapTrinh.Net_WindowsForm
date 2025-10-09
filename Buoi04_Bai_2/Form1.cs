using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH4_Bai2
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
                MessageBox.Show("Hãy nhập số phần tử mảng!", "Thông báo");
            else
            {
                n = int.Parse(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n=" + n + " ,Số phần tử phải lớn hơn 0!", "Thông báo");
                    txtNhap.Focus();
                }        
                else
                {
                   
                    a = new int[n];
                    int num1;
                    Random rd = new Random();
                    for (int i = 0; i < a.Length; i++)
                    {
                        num1 = rd.Next(-10, 100);
                        a[i] = num1;
                    }
                }    
                
            }
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            txtKq.Text = "Các phần tử của mảng: " + InMang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
