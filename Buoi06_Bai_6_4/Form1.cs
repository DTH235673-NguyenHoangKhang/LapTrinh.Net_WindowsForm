using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi06_Bai_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCode.Focus();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem();
            ListViewItem.ListViewSubItem subitem1, subitem2, subitem3, subitem4,subitem5;
            subitem1 = new ListViewItem.ListViewSubItem();
            subitem2 = new ListViewItem.ListViewSubItem();
            subitem3 = new ListViewItem.ListViewSubItem();
            subitem4 = new ListViewItem.ListViewSubItem();
            subitem5 = new ListViewItem.ListViewSubItem();
            item1.Text = txtCode.Text;
            for (int i = 0; i < lvSinhVien.Items.Count; i++)
            {
                if (item1.Text == lvSinhVien.Items[i].Text)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Clear();
                    txtCode.Focus();
                    return;
                }
            }
            subitem1.Text = txtName.Text;
            subitem2.Text = dtNgaysinh.Value.ToShortDateString(); ;
            if(rdoNam.Checked == true)
                subitem3.Text = rdoNam.Text;
            else if (rdoNu.Checked == true)
                subitem3.Text = rdoNu.Text;
            else
            {
                subitem3.Text = "";
            }
            subitem4.Text = txtDienThoai.Text;
            subitem5.Text = txtQueQuan.Text;
            if (subitem1.Text == "" || subitem2.Text == "" || subitem4.Text == "" || subitem5.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            item1.SubItems.Add(subitem1);
            item1.SubItems.Add(subitem2);
            item1.SubItems.Add(subitem3);
            item1.SubItems.Add(subitem4);
            item1.SubItems.Add(subitem5);
            lvSinhVien.Items.Add(item1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvSinhVien.SelectedItems.Count > 0)
            {
                lvSinhVien.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if(lvSinhVien.SelectedItems.Count > 0)
            {
                txtCode.Text = lvSinhVien.SelectedItems[0].Text;
                txtName.Text = lvSinhVien.SelectedItems[0].SubItems[1].Text;
                dtNgaysinh.Text = lvSinhVien.SelectedItems[0].SubItems[2].Text;
                if (lvSinhVien.SelectedItems[0].SubItems[3].Text == "Nam")
                    rdoNam.Checked = true;
                else if (lvSinhVien.SelectedItems[0].SubItems[3].Text == "Nữ")
                    rdoNu.Checked = true;
                txtDienThoai.Text = lvSinhVien.SelectedItems[0].SubItems[4].Text;
                txtQueQuan.Text = lvSinhVien.SelectedItems[0].SubItems[5].Text;
                lvSinhVien.SelectedItems[0].Remove();
               

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
