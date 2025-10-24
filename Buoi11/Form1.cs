using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Buoi11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter dahocsinh;
        SqlDataAdapter daquequan;
        DataSet ds = new DataSet("dsQLHS");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ACER\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";

            string squeryquequan = @"select * from quequan";
            daquequan = new SqlDataAdapter(squeryquequan, conn);
            daquequan.Fill(ds, "tblquequan");
            cboQueQuan.DataSource = ds.Tables["tblquequan"];
            cboQueQuan.DisplayMember = "tenqq";
            cboQueQuan.ValueMember = "maqq";


            string squeryhocsinh = @"select h.*, q.tenqq from hocsinh h, quequan q where h.maqq=q.maqq";
            dahocsinh = new SqlDataAdapter(squeryhocsinh, conn);
            dahocsinh.Fill(ds, "tbldshocsinh");
            dgDSHocSinh.DataSource = ds.Tables["tbldshocsinh"];
            dgDSHocSinh.Columns["mahs"].HeaderText = "Mã Số";
            dgDSHocSinh.Columns["holot"].HeaderText = "Họ lót";
            dgDSHocSinh.Columns["tenhs"].HeaderText = "Tên";
            dgDSHocSinh.Columns["phai"].HeaderText = "Phái";
            dgDSHocSinh.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSHocSinh.Columns["tenqq"].HeaderText = "Quê quán";
            dgDSHocSinh.Columns["mahs"].Width = 80;
            dgDSHocSinh.Columns["holot"].Width = 150;
            dgDSHocSinh.Columns["tenhs"].Width = 100;
            dgDSHocSinh.Columns["phai"].Width = 50;
            dgDSHocSinh.Columns["ngaysinh"].Width = 100;
            dgDSHocSinh.Columns["tenqq"].Width = 150;
            dgDSHocSinh.Columns["maqq"].Visible = false;

            string sThemHS = @"insert into hocsinh values(@Mahs, @HoLot, @TenHS, @Phai, @NgaySinh, @MaQQ)";
            SqlCommand cmThemHS = new SqlCommand(sThemHS, conn);
            cmThemHS.Parameters.Add("@Mahs", SqlDbType.NVarChar, 10, "mahs");
            cmThemHS.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemHS.Parameters.Add("@TenHS", SqlDbType.NVarChar, 10, "tenhs");
            cmThemHS.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemHS.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmThemHS.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 5, "maqq");
            dahocsinh.InsertCommand = cmThemHS;

            string sXoaHS = @"DELETE FROM hocsinh WHERE MaSo = @MaSo";
            SqlCommand cmXoaHS = new SqlCommand(sXoaHS, conn);
            cmXoaHS.Parameters.Add("@MaSo", SqlDbType.NVarChar, 10, "maso");
            dahocsinh.DeleteCommand = cmXoaHS;

            string sSuahs = @"UPDATE hocsinh SET Holot=@HoLot, TenHS=@TenHS, Phai=@Phai, NgaySinh=@NgaySinh, MaQQ=@MaQQ WHERE MaSo=@MaSo";
            SqlCommand cmSuahs = new SqlCommand(sSuahs, conn);
            cmSuahs.Parameters.Add("@Mahs", SqlDbType.NVarChar, 10, "mahs");
            cmSuahs.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmSuahs.Parameters.Add("@TenHS", SqlDbType.NVarChar, 10, "tenhs");
            cmSuahs.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmSuahs.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmSuahs.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 5, "maqq");
            dahocsinh.UpdateCommand = cmSuahs;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = ds.Tables["tbldshocsinh"].Columns["mahs"];
            ds.Tables["tbldshocsinh"].PrimaryKey = primaryKey;

            cboQueQuan.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text == "" || txtHoLot.Text == "" || txtTen.Text == "" || (rdoNam.Checked == false && rdoNu.Checked == false) || dtNgaySinh.Text == "" || cboQueQuan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ds.Tables["tbldshocsinh"].Rows.Find(txtMaSo.Text) != null)
            {
                MessageBox.Show("Mã số học sinh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSo.Clear();
                txtMaSo.Focus();
                return;
            }
            DataRow row;
            row = ds.Tables["tbldshocsinh"].NewRow();
            row["mahs"] = txtMaSo.Text;
            row["holot"] = txtHoLot.Text;
            row["tenhs"] = txtTen.Text;
            if (rdoNam.Checked) row["phai"] = "Nam";
            else row["phai"] = "Nữ";
            row["ngaysinh"] = dtNgaySinh.Text;
            row["maqq"] = cboQueQuan.SelectedValue;
            row["tenqq"] = cboQueQuan.Text;
            ds.Tables["tbldshocsinh"].Rows.Add(row);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSHocSinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn học sinh cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow dr = dgDSHocSinh.SelectedRows[0];
            dr.Cells["mahs"].Value = txtMaSo.Text;
            dr.Cells["holot"].Value = txtHoLot.Text;
            dr.Cells["tenhs"].Value = txtTen.Text;
            if (rdoNam.Checked) dr.Cells["phai"].Value = "Nam";
            else dr.Cells["phai"].Value = "Nữ";
            dr.Cells["ngaysinh"].Value = dtNgaySinh.Text;
            dr.Cells["maqq"].Value = cboQueQuan.SelectedValue;
            dr.Cells["tenqq"].Value = cboQueQuan.Text;


        }

        private void dgDSHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSo.Text = dgDSHocSinh.CurrentRow.Cells["mahs"].Value.ToString();
            txtHoLot.Text = dgDSHocSinh.CurrentRow.Cells["holot"].Value.ToString();
            txtTen.Text = dgDSHocSinh.CurrentRow.Cells["tenhs"].Value.ToString();
            if (dgDSHocSinh.CurrentRow.Cells["phai"].Value.ToString() == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            dtNgaySinh.Text = dgDSHocSinh.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cboQueQuan.Text = dgDSHocSinh.CurrentRow.Cells["tenqq"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSHocSinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn học sinh cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow dr = dgDSHocSinh.SelectedRows[0];
            dgDSHocSinh.Rows.Remove(dr);
            txtMaSo.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cboQueQuan.SelectedIndex = -1;
            MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dahocsinh.Update(ds, "tbldshocsinh");
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tbldshocsinh"].RejectChanges();
            txtMaSo.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            cboQueQuan.SelectedIndex = -1;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
