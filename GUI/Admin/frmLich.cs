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

namespace Second_Try.GUI.Admin
{
    public partial class frmLich : Form
    {
        public frmLich()
        {
            InitializeComponent();
        }

        private void frmLich_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet5.BacSi' table. You can move, or remove it, as needed.
            this.bacSiTableAdapter.Fill(this.quanLyLichKhamDataSet5.BacSi);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadLich();
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void LoadLich()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            int benhNhanID = IdTaiKhoan.idBenhNhanTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                            // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichHen> danhSachLichHen = LichHenDAL.Instance.GetLichHen();
            foreach (var lichHen in danhSachLichHen)
            {
                Second_Try.Entity.BacSi bacSi = TaiKhoanDAL.Instance.GetBacSiByID(lichHen.BacSiID);
                if (bacSi != null)
                {
                    lichHen.BacSiHoTen = bacSi.HoTen;
                }
            }
            var danhSachSapXep = danhSachLichHen.OrderBy(x => x.NgayHen).ToList();

            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["LichHenID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["LichHenID"].Width = 30;
            dataGridView1.Columns["BacSiHoTen"].HeaderText = "Bác sỹ phụ trách";
            dataGridView1.Columns["BacSiHoTen"].Width = 100;
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính";
            dataGridView1.Columns["GioiTinhString"].Width = 40;
            dataGridView1.Columns["BacSiID"].HeaderText = "Bác sỹ ID";
            dataGridView1.Columns["BacSiID"].Width = 50;
            dataGridView1.Columns["BenhNhanID"].HeaderText = "Bệnh nhân ID";
            dataGridView1.Columns["BenhNhanID"].Width = 50;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày hẹn";
            dataGridView1.Columns["NgayHen"].Width = 80;
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ hẹn";
            dataGridView1.Columns["GioHen"].Width = 80;
            dataGridView1.Columns["GioDenThucTe"].HeaderText = "Giờ đến thực tế";
            dataGridView1.Columns["GioDenThucTe"].Width = 80;
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["trangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["trangThaiString"].Width = 100;
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridView1.Columns["GhiChu"].Width = 80;
            dataGridView1.Columns["HoTenNguoiKham"].HeaderText = "Người đăng ký";
            dataGridView1.Columns["HoTenNguoiKham"].Width = 100;
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["SDT"].Width = 80;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["DiaChi"].Width = 100;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void txtBacsiid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ví dụ: Lấy giá trị từ hàng được chọn và hiển thị lên các TextBox
                txtTenBenhNhan.Text = row.Cells["HoTenNguoiKham"].Value.ToString();
                txtLichhenid.Text = row.Cells["LichHenID"].Value.ToString();
                txtghichu.Text = row.Cells["GhiChu"].Value.ToString();
                if (row.Cells["GioDenThucTe"].Value != null)
                {
                    TimeSpan gioDenThucTe = (TimeSpan)row.Cells["GioDenThucTe"].Value;
                    dtpGiothucte.Value = DateTime.Today.Add(gioDenThucTe);
                    txtGioden.Text = gioDenThucTe.ToString(@"hh\:mm");
                }
                else
                {
                    txtGioden.Text = "";
                }
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
                if (row.Cells["TrangThai"].Value.ToString() == "True")
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = false;
                }
                else
                {
                    checkBox2.Checked = true;
                    checkBox1.Checked = false;
                }
                comboBox1.SelectedValue = row.Cells["BacSiID"].Value;
                txtBacsiid.Text = row.Cells["BacSiID"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSdt.Text = row.Cells["SDT"].Value.ToString();
                TimeSpan gioHen = (TimeSpan)row.Cells["GioHen"].Value;
                dtpGiohen.Value = DateTime.Today.Add(gioHen);
                if (row.Cells["GioDenThucTe"].Value != null)
                {
                    TimeSpan gioDenThucTe = (TimeSpan)row.Cells["GioDenThucTe"].Value;
                    dtpGiothucte.Value = DateTime.Today.Add(gioDenThucTe);
                    txtGioden.Text = gioDenThucTe.ToString(@"hh\:mm");
                }
                else
                {
                    dtpGiothucte.Value = DateTime.Today;
                }
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
                dtpngayhen.Value = Convert.ToDateTime(row.Cells["NgayHen"].Value);
            }
        }

        private void cbcCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDatlich_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            DateTime ngayHen = dtpngayhen.Value;
            string ghiChu = txtghichu.Text;
            string hoTenNguoiKham = txtTenBenhNhan.Text;
            string sdt = txtSdt.Text;
            bool gioiTinh = Nam.Checked; // Nam = true, Nữ = false
            string diaChi = txtDiachi.Text;
            bool caLamViec = (cbcCa.SelectedIndex == 0); // Ca sáng = true, Ca chiều = false
            if (txtLichhenid.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lichHenID = Convert.ToInt32(txtLichhenid.Text);
            int bacssiid = Convert.ToInt32(txtBacsiid.Text);

            TimeSpan? gioDen = null;
            if (!string.IsNullOrEmpty(txtGioden.Text))
            {
                gioDen = TimeSpan.Parse(txtGioden.Text);
            }
            if (!checkBox3.Checked)
            {
                gioDen = null;
            }
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
                    MessageBox.Show("Lịch đã được đặt, vui lòng hẹn lịch khác111!");
                    return;
                }
            }
            TimeSpan gioHen = dtpGiohen.Value.TimeOfDay;
            if (caLamViec && (gioHen < new TimeSpan(7, 0, 0) || gioHen > new TimeSpan(12, 0, 0)))
            {
                MessageBox.Show("Giờ hẹn không hợp lệ1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!caLamViec && (gioHen < new TimeSpan(13, 0, 0) || gioHen > new TimeSpan(15, 0, 0)))
            {
                MessageBox.Show("Giờ hẹn không hợp lệ2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBox3.Checked)
            {
                checkBox1.Checked = true;
            }
            bool trangThai = checkBox1.Checked; // Đã khám = true, Chưa khám = false\
            bool ketQua = LichHenBLL.Instance.SuaLichHen(txtLichhenid.Text, comboBox1.SelectedValue.ToString(), ngayHen, gioHen, gioDen, trangThai, ghiChu, diaChi, hoTenNguoiKham, sdt, gioiTinh, diaChi, caLamViec);


            // Kiểm tra trạng thái lịch làm việc

            bool sualichlamviec = LichLamViecDAL.Instance.SuaLichLamViecPlus(lichHenID, bacssiid, ngayHen, gioHen, gioDen, trangThai, caLamViec);
            if (ketQua && sualichlamviec)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadLich(); // Load lại danh sách sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }

        }

        private void dtpGiothucte_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                TimeSpan gioDenThucTe = dtpGiothucte.Value.TimeOfDay;
                txtGioden.Text = gioDenThucTe.ToString(@"hh\:mm");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
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
                        LoadLich(); // Tải lại danh sách lịch hẹn
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

        private void frmLich_Resize(object sender, EventArgs e)
        {

            if (this.Width > 1300)
                dataGridView1.Height = 450;
            else
                dataGridView1.Height = 200;
        }


    }
}
