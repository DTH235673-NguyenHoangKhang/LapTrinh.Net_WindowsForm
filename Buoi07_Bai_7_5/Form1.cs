using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Buoi07_Bai_7_5
{
    // ... [Phần định nghĩa class DrawnShape và các biến trạng thái giữ nguyên] ...

    public partial class Form1 : Form
    {
        // === Biến Trạng thái (được giữ nguyên) ===
        private Point startPoint;
        private Point currentPoint;
        private Point endPoint;

        private bool isDrawing = false;

        private string selectedShape = "Filled Ellipse";
        private Color borderColor = Color.Blue;
        private int borderSize = 4;
        private Color fillColor = Color.Red;

        private List<DrawnShape> drawnShapes = new List<DrawnShape>();

        public Form1()
        {
            InitializeComponent();

            // ... [Phần khởi tạo trong Constructor giữ nguyên] ...
            if (cboShape.Items.Count > 0)
            {
                cboShape.SelectedIndex = 0;
                selectedShape = cboShape.SelectedItem.ToString();
            }

            pnlBorderColor.BackColor = borderColor;
            pnlFillColor.BackColor = fillColor;
            nudBorderSize.Value = borderSize;
        }

        // ... [Phần xử lý sự kiện Chuột và Paint giữ nguyên] ...

        // Hàm tiện ích tính toán Vùng chữ nhật (Bounds)
        private Rectangle GetDrawingRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        // 1. Thay đổi Hình dạng
        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShape.SelectedItem != null)
            {
                selectedShape = cboShape.SelectedItem.ToString();
            }
        }

        // 2. Chọn Màu Viền (Đã sửa lỗi ColorDialog)
        private void pnlBorderColor_Click(object sender, EventArgs e)
        {
            // GIẢ SỬ tên ColorDialog của bạn là colorDialog1 (mặc định)
            // Hoặc bạn phải thay đổi colorDialog1 thành tên bạn đã đặt (ví dụ: colorDlg)
            colorDlg.Color = borderColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                borderColor = colorDlg.Color;
                pnlBorderColor.BackColor = borderColor;
            }
        }

        // 3. Thay đổi Kích thước Viền
        private void nudBorderSize_ValueChanged(object sender, EventArgs e)
        {
            borderSize = (int)nudBorderSize.Value;
        }

        // 4. Chọn Màu Tô (Đã sửa lỗi ColorDialog)
        private void pnlFillColor_Click(object sender, EventArgs e)
        {
            // GIẢ SỬ tên ColorDialog của bạn là colorDialog1 (mặc định)
            // Hoặc bạn phải thay đổi colorDialog1 thành tên bạn đã đặt (ví dụ: colorDlg)
            colorDlg.Color = fillColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDlg.Color;
                pnlFillColor.BackColor = fillColor;
            }
        }

        // ... [Giữ nguyên các hàm xử lý chuột và Paint] ...

        private void pbDrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        // Vẽ tạm thời (kéo chuột)
        private void pbDrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                // Gọi Invalidate để kích hoạt sự kiện Paint, vẽ hình tạm
                pbDrawingArea.Invalidate();
            }
        }

        // Hoàn thành hình (nhả chuột)
        private void pbDrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                isDrawing = false;

                // Tính toán Bounds cuối cùng
                Rectangle finalBounds = GetDrawingRectangle(startPoint, currentPoint);

                // Lưu hình vào danh sách nếu có kích thước hợp lệ
                if (finalBounds.Width > 1 || finalBounds.Height > 1)
                {
                    DrawnShape newShape = new DrawnShape(
                        selectedShape,
                        finalBounds,
                        borderColor,
                        borderSize,
                        fillColor
                    );
                    drawnShapes.Add(newShape);
                }

                // Vẽ lại tất cả (bao gồm hình mới)
                pbDrawingArea.Invalidate();
            }
        }

        // Sự kiện PAINT (Tất cả logic vẽ phải nằm ở đây)
        private void pbDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            // 1. Vẽ tất cả các hình đã hoàn thành (từ danh sách)
            foreach (DrawnShape shape in drawnShapes)
            {
                shape.Draw(e.Graphics);
            }

            // 2. Vẽ hình đang được kéo (tạm thời)
            if (isDrawing)
            {
                Rectangle currentBounds = GetDrawingRectangle(startPoint, currentPoint);

                // Dùng Pen nét đứt và màu mờ cho hình tạm thời
                using (Pen tempPen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot })
                using (SolidBrush tempBrush = new SolidBrush(Color.FromArgb(100, fillColor)))
                {
                    switch (selectedShape)
                    {
                        case "Filled Ellipse":
                            e.Graphics.FillEllipse(tempBrush, currentBounds);
                            e.Graphics.DrawEllipse(tempPen, currentBounds);
                            break;
                        case "Filled Rectangle":
                            e.Graphics.FillRectangle(tempBrush, currentBounds);
                            e.Graphics.DrawRectangle(tempPen, currentBounds);
                            break;
                        case "Line":
                            e.Graphics.DrawLine(tempPen, startPoint, currentPoint);
                            break;
                    }
                }
            }
        }
    }

    // Đặt lại class DrawnShape ở vị trí ban đầu (bên ngoài Form1) để tránh lỗi nếu bạn đã từng đặt nó ở đó.
    // Nếu bạn muốn giữ nó trong Form1, cần đảm bảo nó là public class
    public class DrawnShape
    {
        public string ShapeType { get; set; }
        public Rectangle Bounds { get; set; }
        public Color BorderColor { get; set; }
        public int BorderSize { get; set; }
        public Color FillColor { get; set; }

        public DrawnShape(string type, Rectangle bounds, Color border, int size, Color fill)
        {
            ShapeType = type;
            Bounds = bounds;
            BorderColor = border;
            BorderSize = size;
            FillColor = fill;
        }

        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(BorderColor, BorderSize))
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                switch (ShapeType)
                {
                    case "Filled Ellipse":
                        g.FillEllipse(brush, Bounds);
                        g.DrawEllipse(pen, Bounds);
                        break;
                    case "Filled Rectangle":
                        g.FillRectangle(brush, Bounds);
                        g.DrawRectangle(pen, Bounds);
                        break;
                    case "Line":
                        g.DrawLine(pen, Bounds.Location, new Point(Bounds.Right, Bounds.Bottom));
                        break;
                }
            }
        }
    }
}