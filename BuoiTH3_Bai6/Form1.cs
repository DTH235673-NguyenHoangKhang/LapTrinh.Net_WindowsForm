using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.lstKq.Items.Add(this.txtNhapChuoi.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstKq.Items.Remove(lstKq.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKq.Text=lstKq.SelectedItem.ToString();
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
