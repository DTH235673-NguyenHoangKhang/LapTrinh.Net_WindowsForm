using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi09_Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int KiemTraSoHoanhao(int n)
        {
            int tong = 0;
            for (int i = 1; i < n ; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            if (tong == n)
                return 1;
            else
                return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamLai.Enabled = false;
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            Form2 f2;
            int n = int.Parse(txtN.Text);
            int check = KiemTraSoHoanhao(n);
            f2 = new Form2(check, n);
            f2.ShowDialog();
            btnLamLai.Enabled = true;
            return;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Form3 f3 = new Form3(n);
            f3.ShowDialog();
            btnLamLai.Enabled = true;
            return;

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời",MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
