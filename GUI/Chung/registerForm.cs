using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using Second_Try.Control;

namespace Second_Try
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9.]{3,20}@gmail.com(.vn|)$");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (txtTen_dang_nhap.Text.Trim() == "" || txtMat_khau.Text.Trim() == "" ||
                txtNhap_lai_mk.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (txtMat_khau.Text != txtNhap_lai_mk.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            if (!checkBox1.Checked) { MessageBox.Show("Vui lòng xác nhận về điều khoản sử dụng "); return; }
            if (!checkAccount(txtTen_dang_nhap.Text)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự chữ và số, chữ hoa và chữ thường"); return; }
            string username = txtTen_dang_nhap.Text;
            string password = txtMat_khau.Text;
            string loaiTaiKhoan1 = cmbLoaitaikhoan.SelectedItem?.ToString();
            string loaiTaiKhoan = "";
            if (loaiTaiKhoan1 == "Bác Sỹ")
            {
                loaiTaiKhoan = "BacSi";
            }
            else
            {
                loaiTaiKhoan = "BenhNhan";
            }
            if (TaiKhoanDAL.Instance.KiemTraTonTaiTaiKhoan(username))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(loaiTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isSuccess = TaiKhoanDAL.Instance.DangKy(username, password, loaiTaiKhoan);

            if (isSuccess)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            txtMat_khau.Font = txtNhap_lai_mk.Font =txtTen_dang_nhap.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtTen_dang_nhap.Text = "(Name account)";
            txtMat_khau.Text = "(Password)";
            txtNhap_lai_mk.Text = "(Repeat password)";
            cmbLoaitaikhoan.Text = "(Account type)";
        }

        private void txtTen_dang_nhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_dang_nhap_Click(object sender, EventArgs e)
        {
            txtTen_dang_nhap.ForeColor = Color.Black;
            txtTen_dang_nhap.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtTen_dang_nhap.Text = "";
        }

        private void txtMat_khau_Click(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMat_khau.Text = "";
        }

        private void txtNhap_lai_mk_Click(object sender, EventArgs e)
        {
            txtNhap_lai_mk.ForeColor = Color.Black;
            txtNhap_lai_mk.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtNhap_lai_mk.Text = "";
        }

        

        private void txtTen_dang_nhap_Leave(object sender, EventArgs e)
        {
            if (txtTen_dang_nhap.Text.Trim() == "")
            {
                txtTen_dang_nhap.ForeColor = Color.DarkGray;
                txtTen_dang_nhap.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTen_dang_nhap.Text = "(Name account)";
            }
        }

        private void txtMat_khau_Leave(object sender, EventArgs e)
        {
            if (txtMat_khau.Text.Trim() == "")
            {
                txtMat_khau.ForeColor = Color.DarkGray;
                txtMat_khau.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtMat_khau.Text = "(Pasword)";
            }
        }

        private void txtNhap_lai_mk_Leave(object sender, EventArgs e)
        {
            if (txtNhap_lai_mk.Text.Trim() == "")
            {
                txtNhap_lai_mk.ForeColor = Color.DarkGray;
                txtNhap_lai_mk.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtNhap_lai_mk.Text = "(Repeat pasword)";
            }
        }
        
        

        private void txtTen_dang_nhap_Enter(object sender, EventArgs e)
        {
            txtTen_dang_nhap.ForeColor = Color.Black;
            txtTen_dang_nhap.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtTen_dang_nhap.Text = "";

        }

        private void txtMat_khau_Enter(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMat_khau.Text = "";

        }

        private void txtNhap_lai_mk_Enter(object sender, EventArgs e)
        {
            txtNhap_lai_mk.ForeColor = Color.Black;
            txtNhap_lai_mk.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtNhap_lai_mk.Text = "";

        }

      
    }
}
