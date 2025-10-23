using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Buoi07_Bai_7_4
{

    public partial class Form1 : Form
    {
        private List<System.Windows.Forms.Label> seatLabels;
        private const int SEAT_PRICE = 100000;

        // Biến để theo dõi tổng số tiền hiện tại (của cả ghế đã bán và đang chọn)
        private long totalRevenue = 0;
        public Form1()
        {
            InitializeComponent();
            seatLabels = new List<Label>();
            foreach (Control control in this.Controls)
            {
                if (control is Label && control.Name.StartsWith("label"))
                {
                    // Giả định tên label từ label1 đến label30 là ghế
                    if (int.TryParse(control.Name.Replace("label", ""), out int seatNumber) && seatNumber >= 1 && seatNumber <= 30)
                    {
                        seatLabels.Add((Label)control);
                    }
                }
            }

            // Sắp xếp lại danh sách theo tên (label1, label2,...)
            seatLabels.Sort((l1, l2) =>
                int.Parse(l1.Name.Replace("label", "")).CompareTo(int.Parse(l2.Name.Replace("label", ""))));


            // 2. Thiết lập trạng thái BAN ĐẦU cho các ghế (ví dụ: ghế 14, 15, 23, 24, 25, 26, 27 đã bán)
            InitializeSeatStatuses();

            // 3. Cập nhật hiển thị thành tiền ban đầu
            UpdateTotalAmountDisplay();
        }
        private void InitializeSeatStatuses()
        {
            int[] soldSeats = { 11, 12, 13, 14, 28, 29 }; // Ví dụ các ghế đã bán ban đầu (Màu Vàng)

            foreach (Label seat in seatLabels)
            {
                // Lấy số ghế từ tên (label1 -> 1)
                int seatNumber = int.Parse(seat.Name.Replace("label", ""));

                if (Array.Exists(soldSeats, element => element == seatNumber))
                {
                    // Ghế đã bán (Màu Vàng)
                    seat.BackColor = Color.Gold;
                    totalRevenue += SEAT_PRICE;
                }
                else
                {
                    // Ghế chưa bán (Màu Trắng)
                    seat.BackColor = Color.White;
                }
            }
        }

        // Hàm cập nhật hiển thị tổng tiền
        private void UpdateTotalAmountDisplay()
        {
            // Tính tổng tiền cần thanh toán cho các ghế ĐANG CHỌN (Màu Xanh)
            long selectedAmount = GetSelectedSeatsCount() * SEAT_PRICE;

            // Yêu cầu chỉ nói về thành tiền phải trả cho SỐ GHẾ ĐÃ MUA, nên ta chỉ hiển thị số tiền của ghế đang chọn.
            lblTotalAmount.Text = $"{selectedAmount:N0} VND"; // Định dạng tiền tệ
        }

        // Hàm đếm số ghế đang được chọn
        private int GetSelectedSeatsCount()
        {
            int count = 0;
            foreach (Label seat in seatLabels)
            {
                if (seat.BackColor == Color.Blue)
                {
                    count++;
                }
            }
            return count;
        }

        // ==================== Xử lý sự kiện Click trên Ghế ====================
        private void seatLabel_Click(object sender, EventArgs e)
        {
            Label clickedSeat = (Label)sender;

            if (clickedSeat.BackColor == Color.White)
            {
                // Trạng thái 1: Chưa bán -> Đổi sang đang chọn
                clickedSeat.BackColor = Color.Blue; // Màu Xanh Dương
            }
            else if (clickedSeat.BackColor == Color.Blue)
            {
                // Trạng thái 2: Đang chọn -> Đổi sang chưa bán
                clickedSeat.BackColor = Color.White; // Màu Trắng
            }
            else if (clickedSeat.BackColor == Color.Gold)
            {
                // Trạng thái 3: Đã bán -> Hiển thị thông báo
                MessageBox.Show($"Ghế số {clickedSeat.Text} đã được bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng, không cần cập nhật tiền
            }

            // Cập nhật lại số tiền phải trả sau khi chọn/hủy chọn ghế
            UpdateTotalAmountDisplay();
        }

        // ==================== Xử lý sự kiện Nút Bấm ====================

        // Nút CHỌN (Xác nhận mua)
        private void btnChoose_Click(object sender, EventArgs e)
        {
            int seatsChosen = 0;

            foreach (Label seat in seatLabels)
            {
                if (seat.BackColor == Color.Blue)
                {
                    // Đổi trạng thái từ Đang chọn (Xanh) sang Đã bán (Vàng)
                    seat.BackColor = Color.Gold;
                    seatsChosen++;
                    totalRevenue += SEAT_PRICE; // Cộng vào tổng doanh thu
                }
            }

            if (seatsChosen > 0)
            {
                // Xuất thông báo
                long amountPaid = (long)seatsChosen * SEAT_PRICE;
                MessageBox.Show($"Bạn đã mua thành công {seatsChosen} ghế. Tổng tiền: {amountPaid:N0} VND.", "Xác nhận mua", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset hiển thị thành tiền về 0 (vì đã xác nhận mua)
            lblTotalAmount.Text = "0 VND";
        }

        // Nút HỦY BỎ (Hủy các lựa chọn tạm thời)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Label seat in seatLabels)
            {
                if (seat.BackColor == Color.Blue)
                {
                    // Đổi trạng thái từ Đang chọn (Xanh) trở lại Chưa bán (Trắng)
                    seat.BackColor = Color.White;
                }
            }

            // Thiết lập lại label thành tiền giá trị 0
            lblTotalAmount.Text = "0 VND";
        }

        // Nút THOÁT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            int seatsChosen = 0;

            foreach (Label seat in seatLabels)
            {
                if (seat.BackColor == Color.Blue)
                {
                    // Đổi trạng thái từ Đang chọn (Xanh) sang Đã bán (Vàng)
                    seat.BackColor = Color.Gold;
                    seatsChosen++;
                    totalRevenue += SEAT_PRICE; // Cộng vào tổng doanh thu
                }
            }

            if (seatsChosen > 0)
            {
                // Xuất thông báo
                long amountPaid = (long)seatsChosen * SEAT_PRICE;
                MessageBox.Show($"Bạn đã mua thành công {seatsChosen} ghế. Tổng tiền: {amountPaid:N0} VND.", "Xác nhận mua", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblTotalAmount.Text = "0 VND";

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Label seat in seatLabels)
            {
                if (seat.BackColor == Color.Blue)
                {
                    // Đổi trạng thái từ Đang chọn (Xanh) trở lại Chưa bán (Trắng)
                    seat.BackColor = Color.White;
                }
            }

            // Thiết lập lại label thành tiền giá trị 0
            lblTotalAmount.Text = "0 VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }






}

