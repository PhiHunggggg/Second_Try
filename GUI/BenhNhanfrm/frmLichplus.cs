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

namespace Second_Try.GUI.BenhNhan
{
    public partial class frmLichplus : Form
    {
        public frmLichplus()
        {
            InitializeComponent();
        }
        private List<Button> timeButtons;
        private void frmLichplus_Load(object sender, EventArgs e)
        {
            List<Second_Try.Entity.ChuyenKhoa> danhsachchuyenkhoa = ChuyenKhoaDAL.Instance.GetDanhSachChuyenKhoa();
            siticoneComboBox1.DataSource = danhsachchuyenkhoa;
            siticoneComboBox1.DisplayMember = "TenChuyenKhoa";
            siticoneComboBox1.ValueMember = "ChuyenKhoaID";
            siticoneComboBox1.SelectedIndex = 1;
            siticoneComboBox1.BorderRadius = 19;
            List<Second_Try.Entity.BacSi> danhsachbacsi = BacSiDAL.Instance.GetBacSiByChuyenKhoa(Convert.ToInt32(siticoneComboBox1.SelectedValue));
            siticoneComboBox2.DataSource = danhsachbacsi;
            siticoneComboBox2.DisplayMember = "HoTen";
            siticoneComboBox2.ValueMember = "BacSiID";
            siticoneComboBox2.BorderRadius = 19;
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
            btn7h.Tag =new TimeSpan(7, 0, 0);
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
            btn16h15.Tag = new TimeSpan( 16, 15, 0);
            btn16h30.Tag = new TimeSpan(16, 30, 0);
            btn16h45.Tag = new TimeSpan(16, 45, 0);
            btn17h.Tag = new TimeSpan(17, 0, 0);
            Second_Try.Entity.BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(IdTaiKhoan.idBenhNhanTaiKhoan);
            txtTenBenhNhan.Text = bn.Hoten;
            txtNgaySinh.Text = bn.Ngaysinh.ToString("dd/MM/yyyy");
            txtSdt.Text = bn.Sdt;
            txtDiachi.Text = bn.Diachi;
            if (bn.Gioitinh == true)
            {
                Nam.Checked = true;
                Nu.Checked = false;
            }
            else
            {
                Nam.Checked = false;
                Nu.Checked = true;
            }

        }
        private void CapNhatTrangThaiGio(int bacSiID, DateTime ngay)
        {
            foreach (System.Windows.Forms.Control control in pnlBtn.Controls)
            {
                if (control is Button btn && btn.Tag is TimeSpan gio)
                {

                    bool isBusy = LichLamViecDAL.Instance.CheckCaTrung(bacSiID, ngay, gio);

                    if (isBusy)
                    {
                        btn.BackColor = Color.FromArgb(24,26,27);
                        btn.Enabled = false;
                    }
                    else
                    {

                        btn.Enabled = true;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
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
                txtGioHen.Text = clickedBtn.Tag.ToString();
                if (check == 1)
                {
                    btnDangKi.Enabled = true;
                }
            }

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn7h15_Click(object sender, EventArgs e)
        {
        }

        private void btn7h30_Click(object sender, EventArgs e)
        {
        }

        private void siticoneShapes1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Second_Try.Entity.BacSi bs = TaiKhoanDAL.Instance.GetBacSiByID(Convert.ToInt32(txtBacsiid.Text));
            lblTenbacsi.Text = bs.HoTen;
            lblNgayhen.Text = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            lblThoigianhen.Text = txtGioHen.Text;
            pnlDatLich.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(siticoneComboBox1.SelectedValue == null)
            {
                return;
            }
            if (siticoneComboBox1.SelectedValue is int selectedValue)
            {
                List<Second_Try.Entity.BacSi> danhsachbacsi = BacSiDAL.Instance.GetBacSiByChuyenKhoa(selectedValue);
                siticoneComboBox2.DataSource = danhsachbacsi;
                siticoneComboBox2.DisplayMember = "HoTen";
                siticoneComboBox2.ValueMember = "BacSiID";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBacsiid.Text = siticoneComboBox2.SelectedValue.ToString();
        }
        int check = -1;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            check = 1;
            DateTime ngay = dateTimePicker1.Value.Date;
            int bacSiID = Convert.ToInt32(siticoneComboBox2.SelectedValue);
            txtNgay.Text = ngay.ToString("yyyy-MM-dd");
            CapNhatTrangThaiGio(bacSiID, ngay);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            pnlDatLich.Visible = false;
        }

        private void Nam_CheckedChanged(object sender, EventArgs e)
        {
            if(Nam.Checked)
            {
                Nu.Checked = false;
            }   
        }
        private void Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (Nu.Checked)
            {
                Nam.Checked = false;
            }
        }

        private void btnDatlich_Click(object sender, EventArgs e)
        {
            if(DatLichBLL.Instance.ThemDatLich(txtBacsiid.Text,IdTaiKhoan.idBenhNhanTaiKhoan, txtTenBenhNhan.Text, Nam.Checked, txtSdt.Text, txtDiachi.Text, txtghichu.Text, txtNgay.Text,txtGioHen.Text))
            {
                MessageBox.Show("Đăng ký thành công, vui lòng chờ xác nhận của bác sỹ .");
                pnlDatLich.Visible = false;
            }
            else
            {
                MessageBox.Show("Đặt lịch thất bại");
            }
        }
    }
}

