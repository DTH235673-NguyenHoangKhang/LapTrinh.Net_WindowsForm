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
    public partial class Form1 : Form
    {
        int[]a ;
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
                int n = int.Parse(txtNhap.Text);
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
                MessageBox.Show("Mảng có 10 phần tử phát sinh ngẫu nhiên vừa tạo: " + InMang(), "Thông báo");
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            DialogResult ktra;
            ktra=MessageBox.Show("Các phần tử của mảng: " + InMang() + ", bạn có muốn tính tổng mảng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ktra == DialogResult.OK)
            {
                Form2 f2=new Form2(a);
                f2.ShowDialog();
            } 
                

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult ktra;
            ktra = MessageBox.Show("Các phần tử của mảng: " + InMang() + ", bạn có muốn tìm giá trị lớn nhất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ktra == DialogResult.OK)
            {
                Form3 f3 = new Form3(a);
                f3.ShowDialog();
            }
        }
    }
}
