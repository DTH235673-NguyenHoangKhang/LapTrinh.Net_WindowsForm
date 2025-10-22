using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtHo.Text=="" || txtTen.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu!");
                return;
            }
            TreeNode parent=null;
            TreeNode child=null;
            string hoten=txtTen.Text+","+txtHo.Text;
            for (int i = 0; i < tvDanhba.Nodes.Count; i++)
            {
                if (!string.IsNullOrEmpty(hoten) && tvDanhba.Nodes[i].Text.Length > 0 && 
                    (char.ToUpper(hoten[0])).ToString() == tvDanhba.Nodes[i].Text[0].ToString())
                {
                    parent = tvDanhba.Nodes[i];
                    child = parent.Nodes.Add(hoten);
                    parent.ExpandAll();
                    tvDanhba.SelectedNode = child; 
                    child.EnsureVisible();
                    break;
                }
                   
                    
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
