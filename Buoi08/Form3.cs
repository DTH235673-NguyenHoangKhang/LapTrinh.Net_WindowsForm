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
    public partial class Form3 : Form
    {
        public Form3(int dai, int rong)
        {
            InitializeComponent();
            int d = dai;
            int r = rong;
            txtDienTich.Text = (d * r).ToString();
            txtChuVi.Text = (2 * (d + r)).ToString();
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
