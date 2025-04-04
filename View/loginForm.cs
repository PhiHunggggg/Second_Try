using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Second_Try.Control;
using Second_Try.Model;

namespace Second_Try
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMat_khau.Font = txtTai_khoan.Font = new Font("Arial", 10, FontStyle.Bold);
            txtTai_khoan.Text = "(Account)";
            txtMat_khau.Text = "(Password)";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = checkBox1.Checked;
            pictureBox5.Visible = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                lblLogin.BackColor = Color.Gray;
                txtMat_khau.BackColor = Color.Gray;
                txtTai_khoan.BackColor = Color.Gray;
                btnLogin.BackColor = Color.Gray;
                btnsign.BackColor = Color.Gray;
                checkBox1.BackColor = Color.Gray;
                btnX.BackColor = Color.Gray;
                btnmini.BackColor = Color.Gray;
                lblLogin.ForeColor = Color.Orange;
                btnLogin.FillColor = Color.Orange;
                btnsign.FillColor = Color.Red;
            }
            else
            {
                lblLogin.BackColor = Color.White;
                txtMat_khau.BackColor = Color.White;
                txtTai_khoan.BackColor = Color.White;
                btnLogin.BackColor = Color.White;
                btnsign.BackColor = Color.White;
                checkBox1.BackColor = Color.White;
                btnX.BackColor = Color.White;
                btnmini.BackColor = Color.White;
                lblLogin.ForeColor = Color.DeepSkyBlue;
                btnLogin.FillColor = Color.DeepSkyBlue;
                btnsign.FillColor = Color.MediumBlue;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTai_khoan_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTai_khoan.Text.Trim() == "" || txtTai_khoan.Text == "(Account)") { MessageBox.Show("Vui lòng nhập tên tài khoản. "); return; }
            if (txtMat_khau.Text.Trim() == "" || txtMat_khau.Text == "(Password)") { MessageBox.Show("Vui lòng nhập mật khẩu."); return; }

            string username = txtTai_khoan.Text;
            string password = txtMat_khau.Text; // Cần mã hóa nếu dùng thực tế

            string loaiTaiKhoan = TaiKhoanDAL.Instance.DangNhap(username, password);

            if (loaiTaiKhoan != null)
            {

                /* if (loaiTaiKhoan == "BacSi")
                 {
                     BacSiForm bacSiForm = new BacSiForm();
                     this.Hide();
                     bacSiForm.ShowDialog();
                     this.Show();
                 }
                 else if (loaiTaiKhoan == "BenhNhan")
                 {
                     BenhNhanForm benhNhanForm = new BenhNhanForm();
                     this.Hide();
                     benhNhanForm.ShowDialog();
                     this.Show();
                 }
                 else if (loaiTaiKhoan == "Admin")
                 {
                     AdminForm adminForm = new AdminForm();
                     this.Hide();
                     adminForm.ShowDialog();
                     this.Show();
                 }*/
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login successful !!!");
                int taiKhoanID = TaiKhoanDAL.Instance.GetTaiKhoanID(username, password);
                IdTaiKhoanHienTai.idTaiKhoan = taiKhoanID;

                try
                {
                    IdTaiKhoan.idBenhNhanTaiKhoan = TaiKhoanDAL.Instance.GetBenhNhanID(username, password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy ID bệnh nhân: " + ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản, mật khẩu hoặc email! Vui lòng thử lại.");
                txtTai_khoan.Clear();
                txtMat_khau.Clear();
                txtTai_khoan.Focus();
                this.DialogResult = DialogResult.None;
            }
        }

        private void txtTai_khoan_Click(object sender, EventArgs e)
        {

            txtTai_khoan.ForeColor = Color.Black;
            txtTai_khoan.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtTai_khoan.Text = "";
        }

        private void txtMat_khau_Click(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMat_khau.Text = "";
        }

        private void txtTai_khoan_Leave(object sender, EventArgs e)
        {
            if (txtTai_khoan.Text.Trim() == "")
            {
                txtTai_khoan.ForeColor = Color.DarkGray;
                txtTai_khoan.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTai_khoan.Text = "(Account)";
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

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtTai_khoan_Enter(object sender, EventArgs e)
        {
            txtTai_khoan.ForeColor = Color.Black;
            txtTai_khoan.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtTai_khoan.Text = "";
        }

        private void txtMat_khau_Enter(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMat_khau.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picHide_Click(object sender, EventArgs e)
        {

        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnX_MouseMove(object sender, MouseEventArgs e)
        {
            btnX.BackColor = Color.Red;
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                btnX.BackColor=Color.Gray;
            }
            else
            {
                btnX.BackColor=Color.White;
            }
        }

        private void btnmini_MouseMove(object sender, MouseEventArgs e)
        {
            btnmini.BackColor = Color.DarkGray;
        }

        private void btnmini_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnmini.BackColor = Color.Gray;
            }
            else { 
                btnmini.BackColor=Color.White;
                   }
        }
    }
}
