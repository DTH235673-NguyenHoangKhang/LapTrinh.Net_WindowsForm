using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            txtKetQua.Text=tong.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKetQua.Enabled = false;
        }
    }
}
