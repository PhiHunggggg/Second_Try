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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Second_Try.GUI
{
    public partial class frmDanhSachBenhNhan : Form
    {
        public frmDanhSachBenhNhan()
        {
            InitializeComponent();
        }

        private void frmDanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            LoadBenhNhan();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void LoadBenhNhan()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            List<BenhNhan> danhsachbenhnhan = BenhNhanDAL.Instance.GetDanhSachBenhNhanFull();



            dataGridView1.DataSource = danhsachbenhnhan;
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["BenhNhanID"].HeaderText = "ID bệnh nhân";
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính";
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["TaiKhoanID"].Visible = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txttaikhoanid.Text = row.Cells["TaiKhoanID"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                if (row.Cells["GioiTinhString"].Value.ToString() == "Nam")
                {
                    ckbNam.Checked = true;
                    ckbNu.Checked = false;
                }
                else
                {
                    ckbNam.Checked = false;
                    ckbNu.Checked = true;
                }
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                txtid.Text = row.Cells["BenhNhanID"].Value.ToString();
            }
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNam.Checked)
            {
                ckbNu.Checked = false;
            }
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNu.Checked)
            {
                ckbNam.Checked = false;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            bool gioitinh;
            if (ckbNam.Checked)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            if (BenhNhanBLL.Instance.SuaBenhNhan(Convert.ToInt32(txtid.Text), txtHoTen.Text, txtDiachi.Text, txtSDT.Text, dtpNgaySinh.Value, gioitinh) && TaiKhoanDAL.Instance.DoiThongTinTaiKhoan(Convert.ToInt32(txttaikhoanid.Text), txtTenDangNhap.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadBenhNhan();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            bool gioitinh;
            if (ckbNam.Checked)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }

            int idbenhnhan = BenhNhanBLL.Instance.ThemBenhNhan(txtHoTen.Text, txtDiachi.Text, txtSDT.Text, dtpNgaySinh.Value, gioitinh);
            if (TaiKhoanBLL.Instance.ThemTaiKhoanBenhNhan(txtTenDangNhap.Text, txtMatKhau.Text, "BenhNhan", idbenhnhan))
            {
                MessageBox.Show("Thêm thành công");
                LoadBenhNhan();
            }
            else
            {
                BenhNhanDAL.Instance.XoaBenhNhan(idbenhnhan);
                MessageBox.Show("Thêm thất bại");

            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if(TaiKhoanDAL.Instance.XoaTaiKhoan(Convert.ToInt32(txttaikhoanid.Text))&&BenhNhanDAL.Instance.XoaBenhNhan(Convert.ToInt32(txtid.Text)))
            {
                MessageBox.Show("Xóa thành công");
                LoadBenhNhan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
