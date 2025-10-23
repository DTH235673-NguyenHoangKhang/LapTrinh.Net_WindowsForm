using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_3
{
    public partial class Form1 : Form
    {
        
       
        // Danh sách lưu đường dẫn (path) của tất cả các file ảnh
        private List<string> imagePaths = new List<string>();

        // Chỉ số của ảnh đang hiển thị
        private int currentIndex = -1;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            // Vô hiệu hóa các nút điều hướng và bắt đầu khi chưa có ảnh
            SetControlsEnabled(false);
        }

        private void SetControlsEnabled(bool enabled)
        {
            btnPrevious.Enabled = enabled;
            btnNext.Enabled = enabled;
            btnStart.Enabled = enabled;
        }

        // Hàm tiện ích để hiển thị ảnh
        private void DisplayImage()
        {
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                try
                {
                    // Tải ảnh từ đường dẫn và hiển thị lên PictureBox
                    pictureBoxDisplay.Image = System.Drawing.Image.FromFile(imagePaths[currentIndex]);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu không tải được ảnh
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pictureBoxDisplay.Image = null; // Xóa ảnh nếu danh sách trống hoặc chỉ số không hợp lệ
            }
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập bộ lọc chỉ cho phép chọn các loại file ảnh phổ biến
            openFileDialog.Filter = "Files ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả files|*.*";

            // Cho phép chọn nhiều file
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Xóa danh sách cũ và thêm các file mới được chọn
                imagePaths.Clear();
                imagePaths.AddRange(openFileDialog.FileNames);

                if (imagePaths.Count > 0)
                {
                    // Bắt đầu từ ảnh đầu tiên
                    currentIndex = 0;
                    DisplayImage();
                    SetControlsEnabled(true);
                }
                else
                {
                    SetControlsEnabled(false);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex++;
                // Lặp vòng: nếu đến cuối, quay lại ảnh đầu tiên (index 0)
                if (currentIndex >= imagePaths.Count)
                {
                    currentIndex = 0;
                }
                DisplayImage();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex--;
                // Lặp vòng: nếu nhỏ hơn 0, chuyển đến ảnh cuối cùng
                if (currentIndex < 0)
                {
                    currentIndex = imagePaths.Count - 1;
                }
                DisplayImage();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                // Đảo trạng thái của Timer và nút Bắt đầu
                if (slideShowTimer.Enabled)
                {
                    slideShowTimer.Stop();
                    btnStart.Text = "Bắt đầu"; // Đã dừng
                }
                else
                {
                    slideShowTimer.Start();
                    btnStart.Text = "Dừng"; // Đang chạy
                }
            }
        }

        // Xử lý sự kiện Tick của Timer:
        private void slideShowTimer_Tick(object sender, EventArgs e)
        {
            // Mỗi khi Timer Tick, gọi hàm chuyển ảnh tiếp theo
            btnNext_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đảm bảo Timer dừng trước khi thoát
            slideShowTimer.Stop();

            // Đóng Form hiện tại
            this.Close();
        }
    }
}

