using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;
using Second_Try.Model;
using static System.Windows.Forms.LinkLabel;
namespace Second_Try
{
    public partial class lichfrm : Form
    {
        public lichfrm()
        {
            InitializeComponent();
        }
        private int check = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            
            if (check == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày hẹn trước!");
                return;
            }
            panel5.Visible = true;
            #region doingay
            if (check == 0)
            {
                DateTime today = DateTimeDAL.Instance.GetDate();
                if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Monday)
                {
                    lbl1.Text = today.ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Tuesday)
                {
                    lbl2.Text = today.ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");
                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Wednesday)
                {
                    lbl3.Text = today.ToString("dd/MM/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");

                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Thursday)
                {
                    lbl4.Text = today.ToString("dd/MM/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -3).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");

                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Friday)
                {
                    lbl5.Text = today.ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -4).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -3).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");
                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Saturday)
                {
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 5).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 6).ToString("MM/dd/yyyy");
                }
                else if (DateTimeDAL.Instance.GetDate().DayOfWeek == DayOfWeek.Sunday)
                {
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 5).ToString("MM/dd/yyyy");
                }

            }
            else
            {

                DateTime today = dpk.Value;
                if (today.DayOfWeek == DayOfWeek.Monday)
                {
                    lbl1.Text = today.ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                }
                else if (today.DayOfWeek == DayOfWeek.Tuesday)
                {
                    lbl2.Text = today.ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");
                }
                else if (today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    lbl3.Text = today.ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");

                }
                else if (today.DayOfWeek == DayOfWeek.Thursday)
                {
                    lbl4.Text = today.ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -3).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");

                }
                else if (today.DayOfWeek == DayOfWeek.Friday)
                {
                    lbl5.Text = today.ToString("MM/dd/yyyy");
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, -4).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, -3).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, -2).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, -1).ToString("MM/dd/yyyy");
                }
                else if (today.DayOfWeek == DayOfWeek.Saturday)
                {
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 5).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 6).ToString("MM/dd/yyyy");
                }
                else if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    lbl1.Text = DateTimeDAL.Instance.NextTime(today, 1).ToString("MM/dd/yyyy");
                    lbl2.Text = DateTimeDAL.Instance.NextTime(today, 2).ToString("MM/dd/yyyy");
                    lbl3.Text = DateTimeDAL.Instance.NextTime(today, 3).ToString("MM/dd/yyyy");
                    lbl4.Text = DateTimeDAL.Instance.NextTime(today, 4).ToString("MM/dd/yyyy");
                    lbl5.Text = DateTimeDAL.Instance.NextTime(today, 5).ToString("MM/dd/yyyy");
                }
            }
            #endregion
            int bacSiID;
            bacSiID = Convert.ToInt32(listBoxBacsy.SelectedValue);

            DateTime ngay1;
            if (DateTime.TryParse(lbl1.Text, out ngay1))
            {
            }
            else
            {
                MessageBox.Show("Lỗi: Chuỗi không hợp lệ!");
            }
            DateTime ngay2;
            if (DateTime.TryParse(lbl2.Text, out ngay2))
            {
            }
            else
            {
                MessageBox.Show("Lỗi: Chuỗi không hợp lệ!");
            }
            DateTime ngay3;
            if (DateTime.TryParse(lbl3.Text, out ngay3))
            {
            }
            else
            {
                MessageBox.Show("Lỗi: Chuỗi không hợp lệ!");
            }
            DateTime ngay4;
            if (DateTime.TryParse(lbl4.Text, out ngay4))
            {
            }
            else
            {
                MessageBox.Show("Lỗi: Chuỗi không hợp lệ!");
            }
            DateTime ngay5;
            if (DateTime.TryParse(lbl5.Text, out ngay5))
            {
            }
            else
            {
                MessageBox.Show("Lỗi: Chuỗi không hợp lệ!");
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay1, true))
            {
                T2s.BackColor = Color.Lime;
            }
            else
            {
                T2s.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay1, false))
            {
                t2c.BackColor = Color.Lime;
            }
            else
            {
                t2c.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay2, true))
            {
                t3s.BackColor = Color.Lime;
            }
            else
            {
                t3s.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay2, false))
            {
                t3c.BackColor = Color.Lime;
            }
            else
            {
                t3c.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay3, true))
            {
                t4s.BackColor = Color.Lime;
            }
            else
            {
                t4s.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay3, false))
            {
                t4c.BackColor = Color.Lime;
            }
            else
            {
                t4c.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay4, true))
            {
                t5s.BackColor = Color.Lime;
            }
            else
            {
                t5s.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay4, false))
            {
                t5c.BackColor = Color.Lime;
            }
            else
            {
                t5c.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay5, true))
            {
                t6s.BackColor = Color.Lime;
            }
            else
            {
                t6s.BackColor = Color.Red;
            }
            if (LichLamViecDAL.Instance.CheckTrangThai(bacSiID, ngay5, false))
            {
                t6c.BackColor = Color.Lime;
            }
            else
            {
                t6c.BackColor = Color.Red;
            }

        }



        private void lichfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet2.ChuyenKhoa' table. You can move, or remove it, as needed.
            this.chuyenKhoaTableAdapter.Fill(this.quanLyLichKhamDataSet2.ChuyenKhoa);
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet1.BacSi' table. You can move, or remove it, as needed.
            this.bacSiTableAdapter1.Fill(this.quanLyLichKhamDataSet1.BacSi);
            BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(IdTaiKhoan.idBenhNhanTaiKhoan);
            comboBox1.SelectedIndex = 0;

            if (comboBox1.SelectedValue != null)
            {
                int chuyenKhoaID = Convert.ToInt32(comboBox1.SelectedValue);

                List<BacSi> danhSachBacSi = BacSiDAL.Instance.GetBacSiByChuyenKhoa(chuyenKhoaID);

                listBoxBacsy.DataSource = danhSachBacSi;
                listBoxBacsy.DisplayMember = "HoTen";
                listBoxBacsy.ValueMember = "BacSiID";
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void T2s_Click(object sender, EventArgs e)
        {
            if (T2s.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl1.Text;
                panel3.Visible = true;
                label31.Text = "Sáng";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);

            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void t3s_Click(object sender, EventArgs e)
        {
            if (t3s.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl2.Text;
                panel3.Visible = true;
                label31.Text = "Sáng";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t4s_Click(object sender, EventArgs e)
        {
            if (t4s.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl3.Text;
                panel3.Visible = true;
                label31.Text = "Sáng";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t5s_Click(object sender, EventArgs e)
        {
            if (t5s.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl4.Text;
                panel3.Visible = true;
                label31.Text = "Sáng";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t6s_Click(object sender, EventArgs e)
        {
            if (t6s.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl5.Text;
                panel3.Visible = true;
                label31.Text = "Sáng";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t2c_Click(object sender, EventArgs e)
        {
            if (t2c.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl1.Text;
                panel3.Visible = true;
                label31.Text = "Chiều";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t3c_Click(object sender, EventArgs e)
        {
            if (t3c.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl2.Text;
                panel3.Visible = true;
                label31.Text = "Chiều";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t4c_Click(object sender, EventArgs e)
        {
            if (t4c.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl3.Text;
                panel3.Visible = true;
                label31.Text = "Chiều";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t5c_Click(object sender, EventArgs e)
        {
            if (t5c.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl4.Text;
                panel3.Visible = true;
                label31.Text = "Chiều";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);


            }
        }

        private void t6c_Click(object sender, EventArgs e)
        {
            if (t6c.BackColor == Color.Red)
            {
                MessageBox.Show("Đã có người đăng ký");
            }
            else
            {
                lblNgayhen.Text = lbl5.Text;
                panel3.Visible = true;
                label31.Text = "Chiều";
                lblTenbacsi.Text = listBoxBacsy.GetItemText(listBoxBacsy.SelectedItem);

            }
        }

        private void btnDatlich_Click(object sender, EventArgs e)
        {
            
            DateTime ngayHen;
            if (DateTime.TryParse(lblNgayhen.Text, out ngayHen))
            {

            }
            else
            {
                MessageBox.Show("Ngày hẹn không hợp lệ!");
                return;
            }
            DateTime selectedTime = dateTimePicker1.Value;
            selectedTime = selectedTime.AddMilliseconds(-selectedTime.Millisecond);

            TimeSpan timeSpan = selectedTime.TimeOfDay;
            DateTime ngaySinh;
            if (!DateTime.TryParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            int hour = selectedTime.Hour;
            if (label31.Text == "Sáng")
            {
                if (hour < 7 || hour >= 11)
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 07:00 đến 11:00!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Reset về giá trị hợp lệ gần nhất (mặc định là 07:00)
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 7, 0, 0);
                    return;
                }
            }
            else
            {
                if (hour < 13 || hour >= 17)
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 13:00 đến 17:00!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Reset về giá trị hợp lệ gần nhất (mặc định là 13:00)
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 13, 0, 0);
                    return;
                }
            }
                int lichhenID = LichHenDAL.Instance.ThemLichHen(IdTaiKhoan.idBenhNhanTaiKhoan, Convert.ToInt32(listBoxBacsy.SelectedValue), ngayHen, timeSpan, txtghichu.Text, txtTenBenhNhan.Text, ngaySinh, txtSdt.Text, Nam.Checked, txtDiachi.Text);
            
                bool ca;
            if (label31.Text == "Sáng")
            {
                ca = true;
            }
            else
            {
                ca = false;
            }
            if (lichhenID > 0)
            {

                // Sau đó dùng ID này để thêm vào LichLamViec
                bool themLichLamViec = LichLamViecDAL.Instance.ThemLichLamViec(Convert.ToInt32(listBoxBacsy.SelectedValue), ngayHen, timeSpan, timeSpan.Add(new TimeSpan(2, 0, 0)), false, ca, lichhenID);

                if (themLichLamViec)
                    MessageBox.Show("Thêm lịch hẹn thành công!");
            }
            else
            {
                MessageBox.Show("Thêm lịch hẹn thất bại!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker1.Value;
            int hour = selectedTime.Hour;
            if (label31.Text == "Sáng")
            {
                if (hour < 7 || hour >= 11)
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 07:00 đến 11:00!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Reset về giá trị hợp lệ gần nhất (mặc định là 07:00)
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 7, 0, 0);
                }
            }
            else
            {
                if (hour < 13 || hour >= 17)
                {
                    MessageBox.Show("Chỉ được chọn giờ từ 13:00 đến 17:00!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Reset về giá trị hợp lệ gần nhất (mặc định là 13:00)
                    dateTimePicker1.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 13, 0, 0);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int chuyenKhoaID = Convert.ToInt32(comboBox1.SelectedValue);

                List<BacSi> danhSachBacSi = BacSiDAL.Instance.GetBacSiByChuyenKhoa(chuyenKhoaID);

               listBoxBacsy.DataSource = danhSachBacSi;
                listBoxBacsy.DisplayMember = "HoTen";
                listBoxBacsy.ValueMember = "BacSiID";
            }
        }

        private void dpk_ValueChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void dpk_Enter(object sender, EventArgs e)
        {
            check = 1;
        }

        private void listBoxBacsy_Click(object sender, EventArgs e)
        {
            int bacSiID = (int)listBoxBacsy.SelectedValue; // Use Convert.ToInt32
            BacSi bs = TaiKhoanDAL.Instance.GetBacSiByID(bacSiID);
            lblTenbacsi.Text = bs.HoTen;
        }
    }
}
