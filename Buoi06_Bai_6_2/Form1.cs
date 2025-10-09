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

namespace Buoi06_Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rdoLopA.Checked)
            {
                lstLopA.Items.Add(txtName.Text);
            }
            else if (rdoLopB.Checked)
            {
                lstLopB.Items.Add(txtName.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học!");
            }
        }

        private void btnAtoB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
            else
                MessageBox.Show("Vui lòng chọn sinh viên từ lớp A!");
        }

        private void btnBtoA_Click(object sender, EventArgs e)
        {
            if(lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }    
            else
                MessageBox.Show("Vui lòng chọn sinh viên từ lớp B!");
        }

        private void btnAallB_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                foreach (var item in lstLopA.Items)
                {
                    lstLopB.Items.Add(item);
                }
                lstLopA.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lớp A không có sinh viên!");
            }
        }

        private void btnBallA_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count>0)
            {
                for (int i=0;i<lstLopB.Items.Count; i++)
                {
                    lstLopA.Items.Add(lstLopB.Items[i]);
                }
                lstLopB.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lớp B không có sinh viên!");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0;i<lstLopA.Items.Count;i++)
            {
                sum++;
            }
            for (int i = 0; i < lstLopB.Items.Count; i++)
            {
                sum++;
            }
            MessageBox.Show("Tổng số sinh viên: " + sum);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl=MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl==DialogResult.Yes)
                this.Close();
        }
    }
}
