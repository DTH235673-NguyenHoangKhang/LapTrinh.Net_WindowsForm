using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            ListViewItem item1 = new ListViewItem();
            ListViewItem.ListViewSubItem subitem1,subitem2,subitem3,subitem4;
            subitem1 = new ListViewItem.ListViewSubItem();
            subitem2 = new ListViewItem.ListViewSubItem();
            subitem3 = new ListViewItem.ListViewSubItem();
            subitem4 = new ListViewItem.ListViewSubItem();
            item1.Text = txtMaSV.Text;
            for(int i=0;i< ListView.Items.Count; i++)
            {
                if (item1.Text == ListView.Items[i].Text)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Clear();
                    txtMaSV.Focus();
                    return;
                }
            }
            subitem1.Text = txtName.Text;
            subitem2.Text = txtAddress.Text;
            subitem3.Text= dtNgaysinh.Value.ToShortDateString();
            subitem4.Text = cboLop.Text;
            if(subitem1.Text == "" || subitem2.Text == "" || subitem4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            item1.SubItems.Add(subitem1);
            item1.SubItems.Add(subitem2);
            item1.SubItems.Add(subitem3);
            item1.SubItems.Add(subitem4);
            ListView.Items.Add(item1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          txtMaSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(ListView.SelectedItems.Count > 0)
            {
                ListView.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
