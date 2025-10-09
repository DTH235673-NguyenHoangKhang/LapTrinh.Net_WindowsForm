using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai5
{
    public partial class Form1 : Form
    {
        //phuong thuc tim so lon nhat
        public int TimMax(int so1, int so2)
        {
            if (so1 < so2)
                return so1;
            else
                return so2;
        }
        //phuong thuc tim uoc chung cua 2 so
        public
        string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b); string chuoi = "";
            for
            (int i = 1; i <= max; i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " " + i.ToString();
            return chuoi;
        }
        //phuong thuc tim UCLN cua 2 so
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            int c=1;
            if(a==b)
                return a;
            else
            {
                int min = a > b ? a : b;
                for (int i = min; i > 0; i--)
                    if ((a % i == 0) && (b % i == 0))
                    {
                        c = i;
                        break;
                    }    
                      
            }    
            return c;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtN.Text);
            b = int.Parse(this.txtM.Text);
            if (this.rdo1.Checked == true)
                this.txtKq.Text = TimUocChung(a, b);
            if (this.rdo2.Checked == true)
                this.txtKq.Text = timUCLN(a, b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtKq.Clear();
            this.txtM.Clear();
            this.txtN.Clear();
            this.txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi=MessageBox.Show("Bạn có muốn dừng chương trình không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
                Application.Exit();
        }

    }
}
