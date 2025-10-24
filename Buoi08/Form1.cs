using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoHinhVuong.Checked = true;
            rdoHCN.Checked = false;
            rdoHinhTron.Checked = false;
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Focus();

        }

        private void rdoHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Focus();
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Clear();
        }

        private void rdoHCN_CheckedChanged(object sender, EventArgs e)
        {
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Clear();
            txtBanKinh.Clear();
            txtDai.Focus();
        }

        private void rdoHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = true;
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(rdoHinhVuong.Checked==true)
            {
                if(txtCanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập cạnh hình vuông!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCanh.Focus();
                    return;
                }
                Form2 f2 = new Form2(int.Parse(txtCanh.Text));
                f2.ShowDialog();
                return;
            }
            else
            {
                if (rdoHCN.Checked == true)
                {
                    if(txtDai.Text == "" || txtRong.Text=="")
                    {
                        MessageBox.Show("Bạn chưa nhập hình chữ nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDai.Focus();
                        return;
                    }
                    Form3 f3 = new Form3(int.Parse(txtDai.Text), int.Parse(txtRong.Text));
                    f3.ShowDialog();
                    return;
                }
                else
                {
                    if (txtBanKinh.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập bán kính hình tròn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBanKinh.Focus();
                        return;
                    }
                    Form4 f4 = new Form4(int.Parse(txtBanKinh.Text));
                    f4.ShowDialog();
                    return;
                }
            }
        }
    }
}
