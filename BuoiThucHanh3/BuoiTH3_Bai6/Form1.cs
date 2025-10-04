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
            
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog chonmau= new ColorDialog();
            if (chonmau.ShowDialog() == DialogResult.OK)
            {
                txtKq.ForeColor = chonmau.Color;
                
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstKq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKq.SelectedItem != null)
                txtKq.Text = lstKq.SelectedItem.ToString();
            else
                txtKq.Text = "";

        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog maunen = new ColorDialog();
            if (maunen.ShowDialog() == DialogResult.OK)
            {
                txtKq.BackColor = maunen.Color;
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            FontDialog ft = new FontDialog();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                txtKq.Font = ft.Font;
            }
        }
    }
}
