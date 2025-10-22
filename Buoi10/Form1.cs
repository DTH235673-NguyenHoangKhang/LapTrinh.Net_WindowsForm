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
namespace Buoi10
{
    public partial class QuanLyNhanVien : Form
    {

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ACER\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";

            // Dữ liệu combobox Chức vụ 
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";

            // Dữ liệu datagrid Danh sách nhân viên 
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã Số";
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ lót";
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["manv"].Width = 80;
            dgDSNhanVien.Columns["holot"].Width = 150;
            dgDSNhanVien.Columns["tennv"].Width = 100;
            dgDSNhanVien.Columns["phai"].Width = 50;
            dgDSNhanVien.Columns["ngaysinh"].Width = 100;
            dgDSNhanVien.Columns["tencv"].Width = 150;


            // … đặt tiêu đề tiếng Việt, định độ rộng cho các trường còn lại 
            dgDSNhanVien.Columns["macv"].Visible = false;
            // Command Thêm nhân viên 
            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,
            "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            
            // Command Xóa nhân viên
            string sXoaNV = @"DELETE FROM nhanvien WHERE MaNV = @MaNV";
            SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);

            // Định nghĩa tham số @MaNV
            // Tham số này lấy giá trị từ cột MaSo trong DataTable khi hàng bị xóa.
            cmXoaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");

            // Gán DeleteCommand cho DataAdapter
            daNhanVien.DeleteCommand = cmXoaNV;
            daNhanVien.InsertCommand = cmThemNV;
            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = ds.Tables["tblDSNhanVien"].Columns["manv"];
            ds.Tables["tblDSNhanVien"].PrimaryKey = primaryKey;
           
        }
   
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu hợp lệ (SV tự viết): 
            // - các trường không bỏ trống 
            if (txtMaSo.Text == "" || txtHoLot.Text == "" || txtName.Text == "" || (rdoNam.Checked == false && rdoNu.Checked == false) || dtNgaySinh.Text == "" || cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // - manv không trùng 
            if (ds.Tables["tblDSNhanVien"].Rows.Find(txtMaSo.Text) != null)
            {
                MessageBox.Show("Mã số nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSo.Clear();
                txtMaSo.Focus();
                return;
            }
            // Thêm 1 dòng vào bảng tblNhanVien 
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaSo.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtName.Text;
            if (rdoNu.Checked == true)
            {
                row["phai"] = "F";
            }
            else
            {
                row["phai"] = "M";
            }
            row["ngaysinh"] = dtNgaySinh.Text;
            row["macv"] = cboChucVu.SelectedValue;
            row["tencv"] = cboChucVu.Text;
            ds.Tables["tblDSNhanVien"].Rows.Add(row);

            // Hiển thị tên chức vụ tương ứng (SV tự viết) 

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

      

        private void dgDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            txtMaSo.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtName.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            dtNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgDSNhanVien.SelectedRows[0] != null)
            {
               DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                dr.Cells["manv"].Value = txtMaSo.Text;
                dr.Cells["holot"].Value = txtHoLot.Text;
                dr.Cells["tennv"].Value = txtName.Text;
                if (rdoNam.Checked == true)
                {
                    dr.Cells["phai"].Value = "Nam";
                }
                else
                {
                    dr.Cells["phai"].Value = "Nữ";
                }
                dr.Cells["ngaysinh"].Value = dtNgaySinh.Text;
                dr.Cells["macv"].Value = cboChucVu.SelectedValue;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgDSNhanVien.SelectedRows[0] != null)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                dgDSNhanVien.Rows.Remove(dr);
                txtHoLot.Clear();
                txtMaSo.Clear();
                txtName.Clear();
                rdoNam.Checked = false;
                rdoNu.Checked = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
            dgDSNhanVien.DataSource = null;
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            txtHoLot.Clear();
            txtMaSo.Clear();
            txtName.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            MessageBox.Show("Hủy các thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
