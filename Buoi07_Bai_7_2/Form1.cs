using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi07_Bai_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rootPath = @"C:\Windows\Web\Wallpaper"; // Thay bằng thư mục gốc phù hợp
            if (Directory.Exists(rootPath))
            {
                // 1. Tạo node gốc
                TreeNode rootNode = new TreeNode(Path.GetFileName(rootPath));
                rootNode.Tag = rootPath; // Lưu đường dẫn đầy đủ vào Tag
                treeView1.Nodes.Add(rootNode);

                // 2. Nạp các thư mục con
                LoadDirectories(rootPath, rootNode);
                rootNode.Expand(); // Mở rộng node gốc
            }
        }
         private void LoadDirectories(string currentPath, TreeNode parentNode)
        {
           
                
                string[] subDirs = Directory.GetDirectories(currentPath);

                foreach (string dir in subDirs)
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(dir));
                    subNode.Tag = dir;
                    parentNode.Nodes.Add(subNode);

                    
                }
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 1. Lấy đường dẫn thư mục được chọn
            string selectedPath = e.Node.Tag as string;

            if (string.IsNullOrEmpty(selectedPath) || !Directory.Exists(selectedPath))
                return;

            // 2. Xóa các PictureBox cũ trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // 3. Lọc và lấy các file ảnh
            string[] imageExtensions = { "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp" };
            List<string> imageFiles = new List<string>();

            foreach (string ext in imageExtensions)
            {
                imageFiles.AddRange(Directory.GetFiles(selectedPath, ext, SearchOption.TopDirectoryOnly));
            }

            // 4. Tạo mảng PictureBox động và hiển thị
            foreach (string imageFile in imageFiles)
            {
                try
                {
                    // Tạo một PictureBox (Thumbnail)
                    PictureBox thumbnailBox = new PictureBox();
                    thumbnailBox.Width = 100; // Kích thước thumbnail
                    thumbnailBox.Height = 70;
                    thumbnailBox.SizeMode = PictureBoxSizeMode.Zoom;
                    thumbnailBox.Tag = imageFile; // Lưu đường dẫn ảnh vào Tag

                    // Nạp ảnh (sử dụng Stream để tránh khóa file nếu cần)
                    using (FileStream fs = new FileStream(imageFile, FileMode.Open, FileAccess.Read))
                    {
                        thumbnailBox.Image = Image.FromStream(fs);
                    }

                    // Gắn sự kiện click cho thumbnail
                    thumbnailBox.Click += ThumbnailBox_Click;

                    // Thêm vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(thumbnailBox);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nạp ảnh
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }
        }
        private void ThumbnailBox_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về PictureBox
            PictureBox clickedThumbnail = sender as PictureBox;

            if (clickedThumbnail != null)
            {
                // 1. Lấy đường dẫn ảnh từ Tag
                string imagePath = clickedThumbnail.Tag as string;

                // 2. Kiểm tra và hiển thị ảnh lớn lên pictureBoxMain
                if (File.Exists(imagePath))
                {
                    try
                    {
                        // Xử lý để ảnh lớn không bị khóa file
                        // Tạo một bản sao ảnh và hiển thị
                        Image img = Image.FromFile(imagePath);
                        pictureBoxMain.Image = new Bitmap(img);
                        img.Dispose(); // Giải phóng tài nguyên gốc

                        // Cấu hình hiển thị ảnh lớn
                        pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message);
                    }
                }
            }
        }
    }
}
