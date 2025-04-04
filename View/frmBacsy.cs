using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Second_Try.Control;
using Second_Try.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Second_Try
{
    public partial class frmBacsy : Form
    {
        public frmBacsy()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            pnlOne.SendToBack();
            int chuyenKhoaID = Convert.ToInt32(comboBox1.SelectedValue);

            List<BacSi> danhSachBacSi = BacSiDAL.Instance.GetBacSiByChuyenKhoa(chuyenKhoaID);
            listBacSy.DataSource = danhSachBacSi;
            listBacSy.DisplayMember = "HoTen";
            listBacSy.ValueMember = "BacSiID";
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmBacsy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet3.ChuyenKhoa' table. You can move, or remove it, as needed.
            this.chuyenKhoaTableAdapter.Fill(this.quanLyLichKhamDataSet3.ChuyenKhoa);
            // TODO: This line of code loads data into the '_Quan_ly_firsttryDataSet2.ThongTinBacSy' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Quan_ly_firsttryDataSet1.ThongTinNguoiDungplus' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Quan_ly_firsttryDataSet.Nguoi_dung' table. You can move, or remove it, as needed.

        }
       
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            string searchName = listBacSy.Text;
            int bacSiID = Convert.ToInt32(listBacSy.SelectedValue);
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng cần tìm!");
                return;
            }
            BacSi bs =  TaiKhoanDAL.Instance.GetBacSiByID(bacSiID);
           lblHoTen.Text=bs.HoTen;
            lblTuoi.Text=Convert.ToString(bs.Tuoi);
            lblTrinhdo.Text=bs.Trinhdo;
            lblSDT.Text=bs.SDT;
            lblChucVu.Text=bs.ChucVu;
            lblChiPhiKham.Text=bs.ChiPhiKham;
            lblEmail.Text =bs.Email;
        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel1.BringToFront();
        }

        private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlOne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
