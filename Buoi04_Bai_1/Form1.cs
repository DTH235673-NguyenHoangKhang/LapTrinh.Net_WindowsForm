using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH4_Bai1
{

    public partial class Form1 : Form
    {
        int[] a = new int[10];
        int sopt = 0;

        public void NhapPT(int GiaTri)
        {
            a[sopt] = GiaTri;
            sopt++;
        }

        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }

        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }

        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        public int TongMang()
        {
            int tong = 0;
            for(int i=0;i< sopt; i++)
                tong += a[i];
            return tong;
        }

        public void SapXepTang(int[] a)
        {
            int tam;
            for (int i=0;i<sopt-1; i++)
                for(int j=i+1;j<sopt; j++)
                    if (a[i] > a[j])
                    {
                       
                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;

                    }    
        }

        public void SapXepGiam(int[] a)
        {
            int tam;
            for (int i = 0; i < sopt - 1; i++)
                for (int j = i + 1; j < sopt; j++)
                    if (a[i] < a[j])
                    {

                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;

                    }
        }

        public int DemSoChan(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
                if (a[i] % 2 == 0)
                    dem++;
            return dem;
        }
        public int DemSoLe(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
                if (a[i] % 2 != 0)
                    dem++;
            return dem;
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }

        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }

        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }

        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }

        public Boolean kiemTraSHH(int so)
        {
            int tong = 0;
            if (so <= 0)
                return false;
            else
            {
                for (int i = 1; i < so; i++)
                {
                    if (so % i == 0)
                        tong+=i;
                }
                if (tong != so)
                    return false;
            }
           
            return true;
        }

        public int demSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    dem++;
            }
            return dem;
        }

        public String inSHH()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sopt +1> a.Length)
                MessageBox.Show("Mảng đã đầy!!!", "Thông báo");
            else
                NhapPT(int.Parse(txtNhap.Text));
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String kq = "Các phần tử trong mảng là: ";
            kq += InMang();
            txtKq.Text = kq;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKq.Clear();
            txtNhap.Clear();
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSapxepgiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }
            else
            {
                SapXepGiam(a);
                String kq = "Mảng đã sáp xếp giảm dần!";
                txtKq.Text = kq;
            }


        }

        private void btnSapxeptang_Click(object sender, EventArgs e)
        {

            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }
            else
            {
                SapXepTang(a);
                String kq = "Mảng đã sáp xếp tăng dần!";
                txtKq.Text = kq;

            }


        }

        private void btnDemsochan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }
            else
            {
                String kq = "Số phần tử chẵn trong mảng là ";
                txtKq.Text = kq + DemSoChan(a).ToString();
            }
        }

        private void btnDemsole_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }
            else
            {
                String kq = "Số phần tử lẻ trong mảng là ";
                txtKq.Text = kq + DemSoLe(a).ToString();
            }

        }

        private void btnSonguyento_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }   
            else
                txtKq.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }

        private void btnSohoanhao_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
            {
                txtKq.Text = "Mảng rỗng!";
            }
            else
                txtKq.Text = "Mảng có " + demSHH().ToString() + " số hoàn hảo là " + inSHH();
        }

        private void btnTongmang_Click(object sender, EventArgs e)
        {
            txtKq.Text="Tổng phần tử trong mảng là "+TongMang().ToString();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "mảng rỗng!";
            else
                txtKq.Text = "Ước chung lớn nhất của 2 phần tử đầu tiên: " + timUCLN(a[0], a[1]);
        }

        private void btnTrungbinhmang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "mảng rỗng!";
            else
                txtKq.Text="Trung bình mảng: "+TrungBinhMang().ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "mảng rỗng!";
            else
                txtKq.Text="Số nhỏ nhất là "+TimMin().ToString();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                txtKq.Text = "mảng rỗng!";
            else
                txtKq.Text = "Số lớn nhất là " + TimMax().ToString();

        }
    }
}
