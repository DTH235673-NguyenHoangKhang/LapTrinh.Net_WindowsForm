using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            string Ten =  $"Chào {CboTen.Text}.  Chúc một ngày vui vẽ";
            MessageBox.Show(Ten);
                
        }
    }
}
