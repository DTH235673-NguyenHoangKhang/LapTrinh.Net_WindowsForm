using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "") || (this.txtPass.Text == ""))
                MessageBox.Show("Vui lòng nhập tên ngừi dùng hoặc mật khẩu");
            else
            {
                if ((this.txtUser.Text =="nguyenvanhung") &&(this.txtPass.Text =="abc12345"))
                    {
                    MessageBox.Show("Đăng nhập thành cong", "Thông báo");
                    this.Close();
                    }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtUser.Clear();
                    this.txtPass.Clear();
                    this.txtUser.Focus();
                }    
            }    

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();

        }
    }
}
