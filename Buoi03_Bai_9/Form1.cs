using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH3_Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Thongtin= $"Họ và tên: {txtHoTen.Text} \n";
            Thongtin +=$"Giới tính: {(rdoNam.Checked ? "Nam" : "Nữ")} \n";
            Thongtin +=$"Ngày sinh: {dateNgaySinh.Value.ToShortDateString()} \n";
            Thongtin +=$"Địa chỉ: {txtDiaChi.Text} \n";
            Thongtin +=$"Điện thoại: {txtDienThoai.Text} \n";
            Thongtin += $"Email: {txtEmail.Text} \n";
            Thongtin +=$"Tình trạng: {(chkDiHoc.Checked? "Đang đi học" : "Đang đi làm")} ";
            MessageBox.Show(Thongtin);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dateNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            chkDiHoc.Checked = false;
            chkDiLam.Checked = false;
            txtHoTen.Focus();
            this.Close();
        }
    }
}
