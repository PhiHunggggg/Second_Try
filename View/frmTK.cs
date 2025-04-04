using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;
using Second_Try.Model;

namespace Second_Try.View
{
    public partial class frmTK : Form
    {
        public frmTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTK_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = TaiKhoanDAL.Instance.GetTaiKhoanByID(IdTaiKhoanHienTai.idTaiKhoan);
            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtMatKhau.Text = taiKhoan.MatKhau;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text != txtNhaplai.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int taiKhoanID = IdTaiKhoanHienTai.idTaiKhoan; // Lấy ID từ tài khoản đã đăng nhập
            string tenDangNhapMoi = txtTenDangNhap.Text.Trim();
            string matKhauMoi = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhapMoi) || string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ketQua = TaiKhoanDAL.Instance.DoiThongTinTaiKhoan(taiKhoanID, tenDangNhapMoi, matKhauMoi);
            if (ketQua)
            {
                MessageBox.Show("Đổi thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đổi thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
