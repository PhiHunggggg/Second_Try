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

namespace Second_Try.GUI
{
    public partial class frmDanhSachBacSy : Form
    {
        public frmDanhSachBacSy()
        {
            InitializeComponent();
        }

        private void frmDanhSachBacSy_Load(object sender, EventArgs e)
        {
            this.chuyenKhoaTableAdapter.Fill(this.quanLyLichKhamDataSet4.ChuyenKhoa);
            LoadLichHen();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

        }
        private void LoadLichHen()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            List<BacSi> danhsachbacsy = BacSiDAL.Instance.GetDanhSachBacSyFull();
            foreach (var bacSy in danhsachbacsy)
            {
                ChuyenKhoa ck = ChuyenKhoaDAL.Instance.GetChuyenKhoaByID(bacSy.ChuyenKhoaID);
                if (ck != null)
                {
                    bacSy.ChuyenKhoa = ck.TenChuyenKhoa;
                }
            }

            dataGridView1.DataSource = danhsachbacsy;
            dataGridView1.Columns["BacSiID"].HeaderText = "Bác sỹ ID";
            dataGridView1.Columns["ChuyenKhoaID"].Visible = false;
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView1.Columns["ChuyenKhoa"].HeaderText = "Chuyên khoa";
            dataGridView1.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["TrinhDo"].HeaderText = "Trình độ";
            dataGridView1.Columns["ChucVu"].HeaderText = "Chức vụ";
            dataGridView1.Columns["Tuoi"].HeaderText = "Tuổi";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["ChiPhiKham"].HeaderText = "Chi phí";
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["taikhoanID"].Visible = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["MatKhau"].Value!=null)
                {
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                }
                else {
                        txtMatKhau.Text = "";
                }
                if (row.Cells["TenDangNhap"].Value!=null)
                {
                txtTaiKhoan.Text = row.Cells["TenDangNhap"].Value.ToString();

                }
                else
                {
                    txtTaiKhoan.Text = "";
                }
                if(row.Cells["TaiKhoanID"].Value != null)
                {
                    txtTaiKhoanID.Text = row.Cells["TaiKhoanID"].Value.ToString();
                }
                else
                {
                    txtTaiKhoanID.Text = "";
                }
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtTrinhdo.Text = row.Cells["TrinhDo"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["ChuyenKhoaID"].Value;
                txtChucvu.Text = row.Cells["ChucVU"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtsdt.Text = row.Cells["SDT"].Value.ToString();
                txtChiPhi.Text = row.Cells["ChiPhiKham"].Value.ToString();
                txttuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtbacsiid.Text= row.Cells["BacSiID"].Value.ToString();
                txtchuyenkhoaid.Text = row.Cells["ChuyenKhoaID"].Value.ToString();
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtTrinhdo.Text) || string.IsNullOrEmpty(txtChucvu.Text) || string.IsNullOrEmpty(txttuoi.Text) || string.IsNullOrEmpty(txtChiPhi.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (BacSiBLL.Instance.KiemTraTonTaiTenDangNhap(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            if(txtTaiKhoanID.Text == "0")
            {
                if (BacSiBLL.Instance.SuaBacSy(txtbacsiid.Text, txtHoTen.Text, Convert.ToInt32(comboBox1.SelectedValue), txtsdt.Text, txtemail.Text, txtTrinhdo.Text, txtChucvu.Text, txttuoi.Text, txtChiPhi.Text) && TaiKhoanDAL.Instance.DangKiTaiKhoanBacSy(txtTaiKhoan.Text, txtMatKhau.Text,Convert.ToInt32(txtbacsiid.Text)))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadLichHen();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại1");
                }
            }else if (txtTaiKhoanID.Text != "")
            {
                if (BacSiBLL.Instance.SuaBacSy(txtbacsiid.Text, txtHoTen.Text, Convert.ToInt32(comboBox1.SelectedValue), txtsdt.Text, txtemail.Text, txtTrinhdo.Text, txtChucvu.Text, txttuoi.Text, txtChiPhi.Text) && TaiKhoanDAL.Instance.DoiThongTinTaiKhoan(Convert.ToInt32(txtTaiKhoanID.Text), txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadLichHen();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                if (BacSiBLL.Instance.ThemBacSy(txtHoTen.Text, Convert.ToInt32(comboBox1.SelectedValue), txtsdt.Text, txtemail.Text, txtTrinhdo.Text, txtChucvu.Text, txttuoi.Text, txtChiPhi.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadLichHen();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                int bacsiid = BacSiBLL.Instance.ThemBacSyReturnID(txtHoTen.Text, Convert.ToInt32(comboBox1.SelectedValue), txtsdt.Text, txtemail.Text, txtTrinhdo.Text, txtChucvu.Text, txttuoi.Text, txtChiPhi.Text);
                if (TaiKhoanDAL.Instance.DangKiTaiKhoanBacSy(txtTaiKhoan.Text,txtMatKhau.Text,bacsiid))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadLichHen();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bác sỹ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txtTaiKhoanID.Text != "0")
                    {
                        int bacsiid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BacSiID"].Value);
                        if (TaiKhoanDAL.Instance.XoaTaiKhoan(Convert.ToInt32(txtTaiKhoanID.Text))||BacSiDAL.Instance.XoaBacSy(bacsiid))
                        {
                            MessageBox.Show("Xóa bác sỹ thành công");
                            LoadLichHen();
                        }
                        else
                        {
                            MessageBox.Show("Xóa bác sỹ thất bại");
                        }
                    }
                    else if (txtTaiKhoanID.Text == "0")
                    {
                        int bacsiid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BacSiID"].Value);
                        if (BacSiDAL.Instance.XoaBacSy(bacsiid))
                        {
                            MessageBox.Show("Xóa bác sỹ thành công!");
                            LoadLichHen();
                        }
                        else
                        {
                            MessageBox.Show("Xóa bác sỹ thất bại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa bác sỹ thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã hủy thao tác xóa bác sỹ. ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bác sỹ cần xóa!");

            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            int bacsiid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BacSiID"].Value);
            if (TaiKhoanDAL.Instance.XoaTaiKhoan(Convert.ToInt32(txtTaiKhoanID.Text)))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadLichHen();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }
    }
}
