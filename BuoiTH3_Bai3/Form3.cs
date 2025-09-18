using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.cboWeb.Items.Add("Tuổi trẻ");
            this.cboWeb.Items.Add("Thanh niên");
            this.cboWeb.Items.Add("VNExpress");
            this.cboWeb.Items.Add("Dân trí");
            this.cboWeb.Items.Add("Công an");
            this.cboWeb.Items.Add("24h");
            this.cboWeb.Items.Add("Zingme");
            this.cboWeb.Items.Add("Kênh 14");
            this.cboWeb.Items.Add("Sài Gòn Tiếp Thị");
            this.cboWeb.SelectedItem = "VNExpress";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn chọn web ";
            this.txtKq.Text += this.cboWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cboWeb.SelectedItem = "VNExpress"; this.txtKq.Clear();

        }
    }
}
