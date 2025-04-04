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
    public partial class ThongtinBenhnhanfrm : Form
    {
        public ThongtinBenhnhanfrm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThongtinBenhnhanfrm_Load(object sender, EventArgs e)
        {
           LoadThongTin();

        }
        private void LoadThongTin()
        {
            BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(IdTaiKhoan.idBenhNhanTaiKhoan);
            txtTenBenhNhan.Text = bn.Hoten;
            lblDiachi.Text = bn.Diachi;
            lblSDT.Text = bn.Sdt;
            lblHoten.Text = bn.Hoten;
            lblGioiTinh.Text = bn.Gioitinh == true ? "Nam" : "Nữ";
            lblNgaysinh.Text = bn.Ngaysinh.ToString("dd/MM/yyyy");
            dateTimePicker1.Value = bn.Ngaysinh;
            if (bn.Gioitinh == true)
            {
                ckbNam.Checked = true;
            }
            else
            {
                ckbNu.Checked = true;
            }
            txtDiachi.Text = bn.Diachi;
            txtSDT.Text = bn.Sdt;
        }
        

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh = dateTimePicker1.Value;
            bool gioitinh;
            if (ckbNam.Checked) {
                gioitinh = true;
            } else {
                gioitinh = false;
            }
            bool suaxong = BenhNhanDAL.Instance.SuaThongTinBenhNhan(IdTaiKhoan.idBenhNhanTaiKhoan, txtTenBenhNhan.Text, ngaysinh, gioitinh, txtSDT.Text, txtDiachi.Text);
            if(suaxong)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
            }
            LoadThongTin();
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNam.Checked)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
