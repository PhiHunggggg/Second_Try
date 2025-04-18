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
using Second_Try.Entity;
using Second_Try.GUI.BenhNhan;
using Second_Try.GUI.BenhNhanfrm;
using Second_Try.View;
using Siticone.Desktop.UI.WinForms;

namespace Second_Try
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            pnlMax.Visible = false;
        }
        private Timer mouseCheckTimer;

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(IdTaiKhoan.idBenhNhanTaiKhoan);
            siticoneButton5.Text = bn.Hoten;
            mouseCheckTimer = new Timer();
            mouseCheckTimer.Interval = 50;  // Kiểm tra mỗi 200ms
            mouseCheckTimer.Tick += MouseCheckTimer_Tick;
            mouseCheckTimer.Tick += MouseCheckTimer_Tick2;
            mouseCheckTimer.Start();

        }
        private void MouseCheckTimer_Tick(object sender, EventArgs e)
        {
            Point cursorPosition = this.PointToClient(Cursor.Position);

            if (pnlcheck.Bounds.Contains(cursorPosition))
            {
                pnlMax.Visible = false;
                panelMini.Visible = true;
            }
            else
            {
            }
        }
        private void MouseCheckTimer_Tick2(object sender, EventArgs e)
        {
            Point cursorPosition = this.PointToClient(Cursor.Position);

            if (pnlMax.Visible==true)
            {
                lblHaa.Location = new Point(230, 25);
            }
            else
            {
                lblHaa.Location = new Point(93, 25);
            }
        }
        private void btnBacsy_Click(object sender, EventArgs e)
        {
            lblHaa.Text = "JT APP";
            OpenChildForm(new frmBacsy());
        }

        private void btnBacsy_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnBacsy.FillColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                btnBacsy.FillColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void btnBacsy_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnBacsy.FillColor = Color.DarkGray;
            }
            else
            {
                btnBacsy.FillColor = Color.DeepSkyBlue;
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongtinBenhnhanfrm());
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void panelMini_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = false;
            pnlMax.Visible=true;
        }
        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            panelMini.Visible = false;
            pnlMax.Visible = true;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Có thể để trống nếu không cần vẽ gì
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả nếu không dùng tới sự kiện này
        }
        private void pnlcheck_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả
        }

        private void panelMini_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả
        }
        private void pnlMax_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            // Không cần làm gì cả
        }
        private void btnMenumini_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnMenumini.BackColor = Color.DarkGray;
            }
            else
            {
                btnMenumini.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btnMenumini_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnMenumini.BackColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                btnMenumini.BackColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void siticoneButton3_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton3.FillColor = Color.DarkGray;
            }
            else
            {
                siticoneButton3.FillColor = Color.DeepSkyBlue;
            }
        }

        private void siticoneButton3_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton3.FillColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                siticoneButton3.FillColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void siticoneButton2_MouseEnter(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                siticoneButton2.FillColor = Color.DarkGray;
            }
            else { 
                
                siticoneButton2.FillColor = Color.DeepSkyBlue;
            }
        }

        private void siticoneButton2_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton2.FillColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                siticoneButton2.FillColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void siticoneButton1_MouseEnter_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton1.FillColor = Color.DarkGray;
            }
            else
            {

                siticoneButton1.FillColor = Color.DeepSkyBlue;
            }
        }

        private void siticoneButton1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton1.FillColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                siticoneButton1.FillColor = Color.FromArgb(51, 51, 76);
            }
        }

        private void siticoneButton4_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton4.FillColor = Color.Orange;
            }
            else
            {
                siticoneButton4.FillColor = Color.DeepSkyBlue;
            }
        }
        private void siticoneButton4_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                siticoneButton4.FillColor = Color.FromArgb(23, 23, 23);
            }
            else
            {
                siticoneButton4.FillColor = Color.FromArgb(51, 51, 76);
            }
        }
        private void panel4_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = false;
            pnlMax.Visible = true;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = false;
            pnlMax.Visible = true;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = false;
            pnlMax.Visible = true;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            btnX.BackColor = Color.Red;
        }

        private void mainForm_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void btnX_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnX.BackColor = Color.DimGray;
            }
            else
            {
                btnX.BackColor = Color.RoyalBlue;
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnmaxi_MouseEnter(object sender, EventArgs e)
        {
            if(checkBox1.Checked) {
                btnmaxi.BackColor = Color.DarkGray;
            }
            else
            {
                btnmaxi.BackColor = Color.DarkBlue;
            }
        }

        private void btnmini_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnmini.BackColor = Color.DarkGray;
            }
            else
            {

                btnmini.BackColor = Color.DarkBlue;
            }
        }

        private void btnmini_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnmini.BackColor = Color.DimGray;
            }
            else
            {
                btnmini.BackColor = Color.RoyalBlue;
            }
        }

        private void btnmaxi_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnmaxi.BackColor = Color.DimGray;
            }
            else
            {
                btnmaxi.BackColor = Color.RoyalBlue;
            }
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            lblHaa.Text = "SETTING";
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild = null; // Giải phóng biến
            }
        }
        private void siticoneButton6_Click(object sender, EventArgs e)
        { 
            lblHaa.Text = "HOME";
            OpenChildForm(new Homefrm());
        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void panel4_MouseEnter_1(object sender, EventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panelMini.Visible = true;
            pnlMax.Visible = false;
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            lblHaa.Text = "INFORMATION";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pnlMax.BackColor = Color.FromArgb(23,23,23);
                btnBacsy.FillColor = Color.FromArgb(23, 23, 23);
                siticoneButton1.FillColor = Color.FromArgb(23, 23, 23);
                siticoneButton2.FillColor = Color.FromArgb(23, 23, 23);
                siticoneButton3.FillColor = Color.FromArgb(23,23,23);
                siticoneButton4.FillColor = Color.FromArgb(23, 23, 23);
                pictureBox3.BackColor = Color.FromArgb(23, 23, 23);
                pictureBox4.BackColor = Color.FromArgb(23, 23, 23);
                pictureBox5.BackColor = Color.FromArgb(23, 23, 23);
                pictureBox6.BackColor = Color.FromArgb(23 , 23, 23);
                panelMini.BackColor = Color.FromArgb(23, 23, 23);
                panel2.BackColor = Color.DimGray;
                panel3.BackColor = Color.DimGray;
                lblHaa.ForeColor = Color.OrangeRed;
                siticoneButton5.FillColor = Color.DarkSlateGray;
                siticoneButton6.FillColor = Color.DimGray;
                siticoneButton7.FillColor = Color.DimGray;
                siticoneButton9.FillColor = Color.DimGray;
                btnMenumini.BackColor = Color.FromArgb(23, 23, 23);
                siticoneButton4.ForeColor = Color.White;
                btnmaxi.BackColor = Color.DimGray;
                btnmini.BackColor = Color.DimGray;
                btnX.BackColor = Color.DimGray;
                pictureBox2.BackColor = Color.DarkBlue;
                pictureBox8.BackColor = Color.DarkBlue;
                checkBox1.BackColor = Color.FromArgb(127,127,127);
                pnlMain.BackgroundImage = Image.FromFile(@"C:\Users\pc\OneDrive\Hình ảnh\Ngôn ngữ lập trình\Ảnh hành tinh 2 plus max.png");

                //     pictureBox8.BackColor = Color.Black;
            }
            else {
                pnlMax.BackColor = Color.FromArgb(51, 51, 76);
                panelMini.BackColor = Color.FromArgb(51, 51, 76);
                siticoneButton1.FillColor = Color.FromArgb(51, 51, 76);
                siticoneButton2.FillColor = Color.FromArgb(51, 51, 76);
                siticoneButton3.FillColor = Color.FromArgb(51, 51, 76);
                btnBacsy.FillColor=Color.FromArgb(51, 51, 76);
                siticoneButton4.FillColor = Color.FromArgb(51, 51, 76);
                pictureBox3.BackColor = Color.FromArgb(51, 51, 76);
                pictureBox4.BackColor = Color.FromArgb(51, 51, 76);
                pictureBox5.BackColor = Color.FromArgb(51, 51, 76);
                pictureBox6.BackColor = Color.FromArgb(51, 51, 76);
                pictureBox8.BackColor = Color.DarkOrange;
                panel2.BackColor = Color.RoyalBlue;
                panel3.BackColor = Color.RoyalBlue;
                lblHaa.ForeColor = Color.White;
                siticoneButton5.FillColor = Color.DarkBlue;
                siticoneButton6.FillColor = Color.RoyalBlue;
                siticoneButton7.FillColor = Color.RoyalBlue;
                siticoneButton9.FillColor = Color.RoyalBlue;
                btnMenumini.BackColor = Color.FromArgb(51, 51, 76);
                siticoneButton4.ForeColor = Color.Black;
                btnX.BackColor = Color.RoyalBlue;
                btnmaxi.BackColor = Color.RoyalBlue;
                btnmini.BackColor = Color.RoyalBlue;
                pictureBox2.BackColor = Color.DarkOrange;
                checkBox1.BackColor = Color.White;
                pnlMain.BackgroundImage = Image.FromFile(@"C:\Users\pc\OneDrive\Hình ảnh\Ngôn ngữ lập trình\Ảnh hành tinh 2 promax.png");
                // pictureBox8.BackColor = Color.FromArgb(51, 51, 76);
            }

        }
        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmLichplus());
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new LichHenplus());
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTK());
        }
    }
}
