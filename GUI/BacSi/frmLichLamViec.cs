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
using Second_Try.DAL;
using Second_Try.Entity;

namespace Second_Try.GUI.BacSi
{
    public partial class frmLichLamViec : Form
    {
        public frmLichLamViec()
        {
            InitializeComponent();
        }

        private void siticoneButton1_MouseEnter(object sender, EventArgs e)
        {
            siticoneButton1.FillColor = Color.Orange;
        }

        private void siticoneButton1_MouseLeave(object sender, EventArgs e)
        {
            siticoneButton1.FillColor = Color.FromArgb(24, 26, 27);
        }

        private void siticoneButton2_MouseEnter(object sender, EventArgs e)
        {
            siticoneButton2
                .FillColor = Color.Orange;   
        }

        private void siticoneButton2_MouseLeave(object sender, EventArgs e)
        {
            siticoneButton2.FillColor = Color.FromArgb(24, 26, 27);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        { 
        }
            private void LoadDanhSachLichDat()
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            List<LichLamViec> danhsachLichlamviec = LichLamViecDAL.Instance.GetLichLamViecALL(IdTaiKhoan.idBacSiTaiKhoan);

            var danhSachSapXep = danhsachLichlamviec
                .OrderByDescending(x => x.Ngay) 
                .ToList();


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
    
}
