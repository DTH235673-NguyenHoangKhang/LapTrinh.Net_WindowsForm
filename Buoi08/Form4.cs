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
    public partial class Form4 : Form
    {
        public Form4(int bankinh)
        {
            InitializeComponent();
            int r = bankinh;
            txtDienTich.Text = (Math.PI * r * r).ToString();
            txtChuVi.Text = (2 * Math.PI * r).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
