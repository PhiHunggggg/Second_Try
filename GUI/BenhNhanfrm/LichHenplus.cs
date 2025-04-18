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
using Second_Try.DAL;
using Second_Try.Entity;

namespace Second_Try.GUI.BenhNhanfrm
{
    public partial class LichHenplus : Form
    {
        public LichHenplus()
        {
            InitializeComponent();
        }
        private void LoadDanhSachLichHen()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            int benhNhanID = IdTaiKhoan.idBenhNhanTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                            // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<DatLich> danhsachDatLich = DatLichDAL.Instance.GetLichHenByBenhNhanID(IdTaiKhoan.idBenhNhanTaiKhoan);

            var danhSachSapXep = danhsachDatLich
                .OrderByDescending(x => x.TrangThai)  // TrangThai = 1 (đã xác nhận) lên trước
                .ThenBy(x => x.ThoiGian)              // rồi đến thời gian
                .ToList();

            foreach (var datlich in danhsachDatLich)
            {
                Second_Try.Entity.BacSi bacSi = TaiKhoanDAL.Instance.GetBacSiByID(datlich.BacSiID);
                if (bacSi != null)
                {
                    datlich.BacSiHoTen = bacSi.HoTen;
                }
            }
            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["DatLichID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["HoTen"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày hẹn";
            dataGridView1.Columns["GioDangKi"].HeaderText = "Giờ đăng kí";
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BacSiHoTen"].HeaderText = "Bác sĩ";
            dataGridView1.Columns["TrangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["KhanCapString"].HeaderText = "Khẩn cấp";
            dataGridView1.Columns["BacSiID"].Width = dataGridView1.Columns["DatLichID"].Width = dataGridView1.Columns["BenhNhanID"].Width = 40;
            dataGridView1.Columns["GioDangKi"].HeaderText = "Giờ đăng kí";
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["GioiTinhString"].Visible = false;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["ThoiGian"].HeaderText = "Hẹn vào lúc";
            dataGridView1.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["KhanCap"].Visible = false;
            if (danhsachDatLich.Count == 0)
            {
                lblCount.Text = "Số lich hẹn : 0";
            }
            else
            {
                lblCount.Text = "Số lịch hẹn : " + danhsachDatLich.Count.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void LichHenplus_Load(object sender, EventArgs e)
        {
            LoadDanhSachLichHen();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            var row = dgv.Rows[e.RowIndex];
            if (row.Cells["TrangThai"].Value is bool isDaXacNhan && isDaXacNhan)
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen; // Xanh lá nhạt cho dễ nhìn
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (row.Cells["TrangThai"].Value is bool isDaXacNhan1 && !isDaXacNhan1)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                // Trạng thái mặc định nếu không khẩn cấp và chưa xác nhận
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtDatlichid.Text = row.Cells["DatLichID"].Value.ToString();


                if (row.Cells["TrangThai"].Value is bool isDaXacNhan && isDaXacNhan)
                {
                    pnlDaXacNhan.Visible = true;
                    lblHoTenBacSy.Text = "Họ tên bác sỹ : "+row.Cells["BacSiHoTen"].Value.ToString();
                    lblNgayhen.Text = "Ngày hẹn : " + ((DateTime)row.Cells["NgayHen"].Value).ToString("dd/MM/yyyy");
                    lblGioHen.Text = "Giờ hẹn : "+row.Cells["GioDangKi"].Value.ToString();
                    lblHotenBenhNhan.Text = "Họ tên bệnh nhân : " + row.Cells["HoTen"].Value.ToString();
                    pnltuchoi.Visible = false;
                    pnlHuy.Visible = false;
                    return;
                }
                else if (row.Cells["TrangThai"].Value is bool isDaXacNhan1 && !isDaXacNhan1)
                {
                    pnlDaXacNhan.Visible = false;
                    pnltuchoi.Visible = true;
                    pnlHuy.Visible = false;
                    return;
                }
                else
                {
                    pnlDaXacNhan.Visible = false;
                    pnlHuy.Visible = true;
                    pnltuchoi.Visible = false;
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { 
                DatLichDAL.Instance.XoaDatLich(Convert.ToInt32(txtDatlichid.Text));
                LoadDanhSachLichHen();
                pnlDaXacNhan.Visible = false;
            }
            else
            {
                MessageBox.Show("Từ chối lịch hẹn thất bại");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (DatLichDAL.Instance.XacNhanLichHen(Convert.ToInt32(txtDatlichid.Text)))
            {
                MessageBox.Show("Xác nhận lịch hẹn thành công");
                DatLichDAL.Instance.XoaDatLich(Convert.ToInt32(txtDatlichid.Text));
                LoadDanhSachLichHen();
                pnlDaXacNhan.Visible = false;
            }
            else
            {
                MessageBox.Show("Xác nhận lịch hẹn thất bại");
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            DatLichDAL.Instance.XoaDatLich(Convert.ToInt32(txtDatlichid.Text));
            LoadDanhSachLichHen();
            pnltuchoi.Visible = false;
        }

        private void btnHuylich_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DatLichDAL.Instance.XoaDatLich(Convert.ToInt32(txtDatlichid.Text));
                LoadDanhSachLichHen();
                pnlHuy.Visible = false;
            }
        }
    }
}
