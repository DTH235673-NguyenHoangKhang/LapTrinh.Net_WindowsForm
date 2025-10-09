using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Buoi06_Bai_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ColumnHeader c1 = new ColumnHeader();
           ColumnHeader c2 = new ColumnHeader();
           ColumnHeader c3 = new ColumnHeader();
           ColumnHeader c4 = new ColumnHeader();
           ColumnHeader c5 = new ColumnHeader();
            c1.Text = "Mã SV";
            c2.Text = "Họ tên";
            c3.Text = "Địa chỉ";
            c4.Text = "Ngày sinh";
            c5.Text = "Lớp";
           ListView.Columns.Add(c1);
            ListView.Columns.Add(c2);
            ListView.Columns.Add(c3);
            ListView.Columns.Add(c4);
            ListView.Columns.Add(c5);

        }
    }
}
