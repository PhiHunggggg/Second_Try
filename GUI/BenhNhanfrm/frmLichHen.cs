using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.BLL;
using Second_Try.Control;
using Second_Try.Entity;

namespace Second_Try.View
{
    public partial class frmLichHen : Form
    {
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLichHen();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ví dụ: Lấy giá trị từ hàng được chọn và hiển thị lên các TextBox
                txtTenBenhNhan.Text = row.Cells["HoTenNguoiKham"].Value.ToString();

                txtghichu.Text = row.Cells["GhiChu"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "True")
                {
                    Nam.Checked = true;
                    Nu.Checked = false;
                }
                else
                {
                    Nu.Checked = true;
                    Nam.Checked = false;
                }
                txtBacsiid.Text = row.Cells["BacSiID"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSdt.Text = row.Cells["SDT"].Value.ToString();
                TimeSpan gioHen = (TimeSpan)row.Cells["GioHen"].Value;
                dateTimePicker1.Value = DateTime.Today.Add(gioHen);
                lblTenbacsi.Text = row.Cells["BacSiHoTen"].Value.ToString();

                TimeSpan startTime = new TimeSpan(7, 0, 0);  // 07:00:00
                TimeSpan endTime = new TimeSpan(12, 0, 0);   // 12:00:00

                if (startTime <= gioHen && gioHen <= endTime)
                {
                    cbcCa.SelectedIndex = 0; // Chọn ca 1
                }
                else
                {
                    cbcCa.SelectedIndex = 1; // Chọn ca 1

                }
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayHen"].Value);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (Nam.Checked == true)
            {
                Nu.Checked = false;
            }
        }

        private void Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (Nu.Checked == true)
            {
                Nam.Checked = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadLichHen()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            int benhNhanID = IdTaiKhoan.idBenhNhanTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                            // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichHen> danhSachLichHen = LichHenDAL.Instance.GetLichHenByBenhNhanID(benhNhanID);
            foreach (var lichHen in danhSachLichHen)
            {
                BacSi bacSi = TaiKhoanDAL.Instance.GetBacSiByID(lichHen.BacSiID);
                if (bacSi != null)
                {
                    lichHen.BacSiHoTen = bacSi.HoTen;
                }
            }

            dataGridView1.DataSource = danhSachLichHen;
            dataGridView1.Columns["LichHenID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BacSiHoTen"].HeaderText = "Bác sỹ phụ trách";
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính";
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDenThucTe"].Visible = false;
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridView1.Columns["HoTenNguoiKham"].HeaderText = "Người đăng ký";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
        private void btnDatlich_Click(object sender, EventArgs e)
        {
            if (DateTimeBLL.Instance.CheckDate(dateTimePicker2.Value) == false)
            {
                MessageBox.Show("Ngày hẹn không được nhỏ hơn ngày hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker2.Value = DateTime.Today;
                return;
            }
            int lichHenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LichHenID"].Value);
            // Chỉnh định dạng giờ
            DateTime selectedTime = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                dateTimePicker1.Value.Hour,
                dateTimePicker1.Value.Minute,
                0 // Bỏ giây và milliseconds
            );

            TimeSpan gioHen = selectedTime.TimeOfDay;
            if (DateTimeBLL.Instance.CheckWeekend(dateTimePicker2.Value))
            {
                MessageBox.Show("Ngày hẹn không được vào cuối tuần!");
                dateTimePicker2.Value = DateTime.Today;
                return;
            }
            if (cbcCa.SelectedIndex == 0) // Ca sáng: 07:00 - 11:59
            {
                if (gioHen < new TimeSpan(7, 0, 0) || gioHen >= new TimeSpan(12, 0, 0))
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 07:00 đến 11:59!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 7, 0, 0);
                    return;
                }
            }
            else // Ca chiều: 13:00 - 16:59
            {
                if (gioHen < new TimeSpan(13, 0, 0) || gioHen >= new TimeSpan(17, 0, 0))
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 13:00 đến 16:59!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 13, 0, 0);
                    return;
                }
            }

            // Lấy thông tin từ các trường nhập liệu
            DateTime ngayHen = dateTimePicker2.Value;
            string ghiChu = txtghichu.Text;
            string hoTenNguoiKham = txtTenBenhNhan.Text;
            string sdt = txtSdt.Text;
            bool gioiTinh = Nam.Checked; // Nam = true, Nữ = false
            string diaChi = txtDiachi.Text;
            bool caLamViec = cbcCa.SelectedIndex == 0; // Ca sáng = true, Ca chiều = false

            int bacssiid = Convert.ToInt32(txtBacsiid.Text);

            LichHen lichHienTai = LichHenDAL.Instance.GetLichHenByID(lichHenID);

            // Kiểm tra nếu ngày hẹn hoặc ca làm việc có thay đổi
            bool ngayHenThayDoi = lichHienTai.NgayHen.Date != ngayHen.Date;
            TimeSpan giohenhientai = lichHienTai.GioHen;
            bool calamviechientai;
            if (giohenhientai >= new TimeSpan(7, 0, 0) && giohenhientai <= new TimeSpan(12, 0, 0))
            {
                calamviechientai = true; // Ca sáng
            }
            else
            {
                calamviechientai = false; // Ca chiều
            }
            bool caLamViecThayDoi = calamviechientai != caLamViec;

            // Nếu có thay đổi ngày hẹn hoặc ca làm việc, mới kiểm tra trạng thái lịch
            if (ngayHenThayDoi || caLamViecThayDoi)
            {
                bool checkTrangThai = LichLamViecDAL.Instance.CheckTrangThai(bacssiid, ngayHen, caLamViec);
                if (!checkTrangThai)
                {
                    MessageBox.Show("Lịch đã được đặt, vui lòng hẹn lịch khác!");
                    return;
                }
            }

            bool ketQua = LichHenDAL.Instance.SuaLichHen(lichHenID, ngayHen, gioHen,
                                               ghiChu, hoTenNguoiKham, sdt, gioiTinh, diaChi);


            // Kiểm tra trạng thái lịch làm việc

            bool sualichlamviec = LichLamViecDAL.Instance.SuaLichLamViec(lichHenID, ngayHen, gioHen, cbcCa.SelectedIndex == 0);
            if (ketQua && sualichlamviec)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadLichHen(); // Load lại danh sách sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int lichHenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LichHenID"].Value);
                    if (LichHenDAL.Instance.XoaLichHenVaLichLamViec(lichHenID))
                    {
                        MessageBox.Show("Xóa lịch hẹn thành công!");
                        LoadLichHen(); // Tải lại danh sách lịch hẹn
                    }
                    else
                    {
                        MessageBox.Show("Xóa lịch hẹn thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy thao tác xóa lịch hẹn.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn để xóa!");

            }

        }
    }  
}
