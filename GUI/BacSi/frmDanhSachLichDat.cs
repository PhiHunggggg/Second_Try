﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Second_Try.GUI.BacSi
{
    public partial class frmDanhSachLichDat : Form
    {
        public frmDanhSachLichDat()
        {
            InitializeComponent();
        }
        private List<Button> timeButtons;

        private void frmDanhSachLichDat_Load(object sender, EventArgs e)
        {
            LoadDanhSachLichDat();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            timeButtons = new List<Button>()
            {
                 btn7h, btn7h15, btn7h30, btn7h45,
                 btn8h, btn8h15, btn8h30, btn8h45,
                 btn9h, btn9h15, btn9h30, btn9h45,
                 btn10h, btn10h15, btn10h30, btn10h45,
                 btn11h,
                  btn14h, btn14h15, btn14h30, btn14h45,
                 btn15h, btn15h15, btn15h30, btn15h45,
                 btn16h, btn16h15, btn16h30, btn16h45,
                  btn17h
            };
            foreach (var btn in timeButtons)
            {
                btn.Click += TimeButton_Click;
            }
            btn7h.Tag = new TimeSpan(7, 0, 0);
            btn7h15.Tag = new TimeSpan(7, 15, 0);
            btn7h30.Tag = new TimeSpan(7, 30, 0);
            btn7h45.Tag = new TimeSpan(7, 45, 0);
            btn8h.Tag = new TimeSpan(8, 0, 0);
            btn8h15.Tag = new TimeSpan(8, 15, 0);
            btn8h30.Tag = new TimeSpan(8, 30, 0);
            btn8h45.Tag = new TimeSpan(8, 45, 0);
            btn9h.Tag = new TimeSpan(9, 0, 0);
            btn9h15.Tag = new TimeSpan(9, 15, 0);
            btn9h30.Tag = new TimeSpan(9, 30, 0);
            btn9h45.Tag = new TimeSpan(9, 45, 0);
            btn10h.Tag = new TimeSpan(10, 0, 0);
            btn10h15.Tag = new TimeSpan(10, 15, 0);
            btn10h30.Tag = new TimeSpan(10, 30, 0);
            btn10h45.Tag = new TimeSpan(10, 45, 0);
            btn11h.Tag = new TimeSpan(11, 0, 0);
            btn14h.Tag = new TimeSpan(14, 0, 0);
            btn14h15.Tag = new TimeSpan(14, 15, 0);
            btn14h30.Tag = new TimeSpan(14, 30, 0);
            btn14h45.Tag = new TimeSpan(14, 45, 0);
            btn15h.Tag = new TimeSpan(15, 0, 0);
            btn15h15.Tag = new TimeSpan(15, 15, 0);
            btn15h30.Tag = new TimeSpan(15, 30, 0);
            btn15h45.Tag = new TimeSpan(15, 45, 0);
            btn16h.Tag = new TimeSpan(16, 0, 0);
            btn16h15.Tag = new TimeSpan(16, 15, 0);
            btn16h30.Tag = new TimeSpan(16, 30, 0);
            btn16h45.Tag = new TimeSpan(16, 45, 0);
            btn17h.Tag = new TimeSpan(17, 0, 0);
        }
        TimeSpan selectedTime;
        private void TimeButton_Click(object sender, EventArgs e)
        {
            Color defaultColor = Color.FromArgb(24, 26, 27);
            Color selectedColor = Color.FromArgb(17, 102, 49);

            foreach (var btn in timeButtons)
            {
                btn.BackColor = defaultColor;
            }

            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                clickedBtn.BackColor = selectedColor;
                clickedBtn.Tag = clickedBtn.Tag; // Lưu lại thời gian đã chọn
                selectedTime = (TimeSpan)clickedBtn.Tag;
                LoadDanhSachLichDat();
            }

        }
        private void CapNhatTrangThaiGio(int bacSiID, DateTime ngay)
        {
            foreach (System.Windows.Forms.Control control in pnlBtn.Controls)
            {
                if (control is Button btn && btn.Tag is TimeSpan gio)
                {
                    bool isBusy = DatLichDAL.Instance.CheckCaTrungDatLich(bacSiID, ngay, gio);

                    if (isBusy)
                    {
                        btn.Enabled = true;
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(24, 26, 27);
                        btn.Enabled = false;
                    }
                }
            }
        }
        private void LoadDanhSachLichDat()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            int benhNhanID = IdTaiKhoan.idBenhNhanTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                            // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<DatLich> danhsachDatLich = DatLichDAL.Instance.GetLichHenByBacSiID(IdTaiKhoan.idBacSiTaiKhoan, dtpNgaycheck.Value.Date, selectedTime);

            var danhSachSapXep = danhsachDatLich
                .OrderByDescending(x => x.TrangThai)  // TrangThai = 1 (đã xác nhận) lên trước
                .ThenBy(x => x.ThoiGian)              // rồi đến thời gian
                .ToList();

            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["DatLichID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BenhNhanID"].HeaderText = "Bệnh Nhân ID";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên bệnh nhân";
            dataGridView1.Columns["NgayHen"].Visible = false;
            dataGridView1.Columns["GioDangKi"].HeaderText = "Giờ đăng kí";
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BacSiHoTen"].Visible = false;
            dataGridView1.Columns["TrangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["KhanCapString"].HeaderText = "Khẩn cấp";
            dataGridView1.Columns["BacSiID"].Width = dataGridView1.Columns["DatLichID"].Width = dataGridView1.Columns["BenhNhanID"].Width = 40;
            dataGridView1.Columns["GioDangKi"].HeaderText = "Giờ đăng kí";
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính" ;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["ThoiGian"].HeaderText = "Hẹn vào lúc";
            dataGridView1.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["KhanCap"].Visible = false;
            if (danhsachDatLich.Count == 0)
            {
                lblCount.Text = "0";
            }
            else
            {
                lblCount.Text = danhsachDatLich.Count.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dtpNgaycheck_ValueChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            CapNhatTrangThaiGio(IdTaiKhoan.idBacSiTaiKhoan, dtpNgaycheck.Value.Date);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            var row = dgv.Rows[e.RowIndex];
            if (row.Cells["KhanCap"].Value is bool isKhanCap && isKhanCap)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (row.Cells["TrangThai"].Value is bool isDaXacNhan && isDaXacNhan)
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen; // Xanh lá nhạt cho dễ nhìn
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Trạng thái mặc định nếu không khẩn cấp và chưa xác nhận
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ví dụ: Lấy giá trị từ hàng được chọn và hiển thị lên các TextBox
                lblHoTen.Text = row.Cells["HoTen"].Value.ToString();

                lblDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "True")
                {
                    lblGioiTinh.Text = "Nam";
                }
                else
                {
                    lblGioiTinh.Text = "Nữ";
                }
                lblSdt.Text = row.Cells["SDT"].Value.ToString();
                lblDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                lblSdt.Text = row.Cells["SDT"].Value.ToString();
                txtGhichu.Text = row.Cells["GhiChu"].Value.ToString();
                if (row.Cells["KhanCap"].Value.ToString() == "True")
                {
                    lblKhancap.Visible = true;
                }
                else
                {
                    lblKhancap.Visible = false;
                }
                txtDatLichid.Text = row.Cells["DatLichID"].Value.ToString();
                if (DatLichBLL.Instance.DemSoLichDaXacNhan(row.Cells["BacSiID"].Value.ToString(), row.Cells["Ngayhen"].Value.ToString(), row.Cells["GioDangKi"].Value.ToString()) >= 1)
                {
                    DaDuocXacNhan = true;
                }
                else
                {
                    DaDuocXacNhan = false;
                }
            }
        }
        bool DaDuocXacNhan;
        private void siticoneShapes2_Click(object sender, EventArgs e)
        {

        }

        private void lblKhancap_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (DaDuocXacNhan)
            {
                MessageBox.Show("Lịch hẹn đã được xác nhận, không thể xác nhận lại, vui lòng hủy lịch trước để d");
                return;
            }
            if (DatLichDAL.Instance.XacNhanLichHenMini(Convert.ToInt32(txtDatLichid.Text)))
            {
                MessageBox.Show("Xác nhận lịch hẹn thành công");
                LoadDanhSachLichDat();
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Xác nhận lịch hẹn thất bại");
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (DatLichDAL.Instance.HuyLichHen(Convert.ToInt32(txtDatLichid.Text)))
            {
                MessageBox.Show("Từ chối lịch hẹn thành công");
                LoadDanhSachLichDat();
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Từ chối lịch hẹn thất bại");
            }
        }
    }
}  
