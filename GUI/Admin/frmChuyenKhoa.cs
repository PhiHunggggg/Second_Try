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

namespace Second_Try.GUI.Admin
{
    public partial class frmChuyenKhoa : Form
    {
        public frmChuyenKhoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChuyenKhoa_Load(object sender, EventArgs e)
        {
            LoadChuyenKhoa();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void LoadChuyenKhoa()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            List<ChuyenKhoa> danhsachchuyenkhoa = ChuyenKhoaDAL.Instance.GetDanhSachChuyenKhoa();
            
            

            dataGridView1.DataSource = danhsachchuyenkhoa;
            dataGridView1.Columns["ChuyenKhoaID"].HeaderText = "Id chuyên khoa";
            dataGridView1.Columns["TenChuyenKhoa"].HeaderText = "Tên chuyên khoa";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["TenChuyenKhoa"].Value != null)
                {
                    txtChuyenKhoa.Text = row.Cells["TenChuyenKhoa"].Value.ToString();
                    txtchuyenkhoaid.Text = row.Cells["ChuyenKhoaID"].Value.ToString();
                }
                else
                {
                    txtChuyenKhoa.Text = "";
                    txtchuyenkhoaid.Text = "";
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(txtChuyenKhoa.Text== "")
            {
                MessageBox.Show("Vui lòng nhập tên chuyên khoa");
            }
            else
            {
                if (ChuyenKhoaBLL.Instance.ThemChuyenKhoa(txtChuyenKhoa.Text))
                {
                    MessageBox.Show("Thêm chuyên khoa thành công");
                    LoadChuyenKhoa();
                }
                else
                {
                    MessageBox.Show("Thêm chuyên khoa thất bại");
                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if(txtChuyenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chuyên khoa");
            }
            else
            {
                ChuyenKhoa chuyenKhoa = new ChuyenKhoa();
                chuyenKhoa.TenChuyenKhoa = txtChuyenKhoa.Text;
                if (ChuyenKhoaDAL.Instance.SuaChuyenKhoa(Convert.ToInt32(txtchuyenkhoaid.Text),txtChuyenKhoa.Text))
                {
                    MessageBox.Show("Cập nhật chuyên khoa thành công");
                    LoadChuyenKhoa();
                }
                else
                {
                    MessageBox.Show("Cập nhật chuyên khoa thất bại");
                }
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if(txtchuyenkhoaid.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa để xóa");
            }
            else
            {
                if (ChuyenKhoaDAL.Instance.XoaChuyenKhoa(Convert.ToInt32(txtchuyenkhoaid.Text)))
                {
                    MessageBox.Show("Xóa chuyên khoa thành công");
                    LoadChuyenKhoa();
                }
                else
                {
                    MessageBox.Show("Xóa chuyên khoa thất bại");
                }
            }
        }
    }
}
