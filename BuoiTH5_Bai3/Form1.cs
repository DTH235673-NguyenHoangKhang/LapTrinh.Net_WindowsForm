using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void RutGonPhanSo(ref int tu, ref int mau)
        {
            int min = tu >= mau ? tu : mau;
            for(int i=2;i<=min;i++)
                if((tu%i==0) && (mau%i==0))
                {
                    tu=tu/i; mau=mau/i;
                }    

        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int mau2 = int.Parse(txtMau2.Text);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(mau1==0)
                       txtMau1.Focus();
                else txtMau2.Focus();
            }
            else
            {
                int kqtu = tu1 * mau2 + tu2 * mau1;
                int kqmau = mau1 * mau2;
                RutGonPhanSo(ref kqtu, ref kqmau);
                txtKqTu.Text=kqtu.ToString();
                txtKqMau.Text=kqmau.ToString();
                grbKq.Text = "Kết quả cộng";
            }    

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int mau2 = int.Parse(txtMau2.Text);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (mau1 == 0)
                    txtMau1.Focus();
                else txtMau2.Focus();
            }
            else
            {
                int kqtu = tu1 * mau2 - tu2 * mau1;
                int kqmau = mau1 * mau2;
                RutGonPhanSo(ref kqtu,ref kqmau);
                txtKqTu.Text = kqtu.ToString();
                txtKqMau.Text = kqmau.ToString();
                grbKq.Text="Kết quả trừ";

            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int mau2 = int.Parse(txtMau2.Text);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (mau1 == 0)
                    txtMau1.Focus();
                else txtMau2.Focus();
            }
            else
            {
                int kqtu = tu1 *tu2 ;
                int kqmau = mau1 * mau2;
                RutGonPhanSo(ref kqtu, ref kqmau);
                txtKqTu.Text = kqtu.ToString();
                txtKqMau.Text = kqmau.ToString();
                grbKq.Text = "Kết quả nhân";

            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txtTu1.Text);
            int tu2 = int.Parse(txtTu2.Text);
            int mau1 = int.Parse(txtMau1.Text);
            int mau2 = int.Parse(txtMau2.Text);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (mau1 == 0)
                    txtMau1.Focus();
                else txtMau2.Focus();
            }
            else
            {
                int kqtu = tu1 * mau2;
                int kqmau = mau1 * tu2;
                RutGonPhanSo(ref kqtu, ref kqmau);
                txtKqTu.Text = kqtu.ToString();
                txtKqMau.Text = kqmau.ToString();
                grbKq.Text = "Kết quả chia";

            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTu1.Clear();
            txtTu2.Clear();
            txtMau1.Clear();
            txtMau2.Clear();
            txtKqTu.Clear();
            txtKqMau.Clear();
            txtTu1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs=MessageBox.Show("Bạn có muốn dừng chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
