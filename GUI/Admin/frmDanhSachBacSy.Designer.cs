namespace Second_Try.GUI
{
    partial class frmDanhSachBacSy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTaiKhoanID = new System.Windows.Forms.TextBox();
            this.txtchuyenkhoaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbacsiid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txttuoi = new System.Windows.Forms.TextBox();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtTrinhdo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chuyenKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyLichKhamDataSet4 = new Second_Try.QuanLyLichKhamDataSet4();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chuyenKhoaTableAdapter = new Second_Try.QuanLyLichKhamDataSet4TableAdapters.ChuyenKhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 360);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.siticoneButton4);
            this.panel2.Controls.Add(this.txtTaiKhoanID);
            this.panel2.Controls.Add(this.txtchuyenkhoaid);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtbacsiid);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtChucvu);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.txtChiPhi);
            this.panel2.Controls.Add(this.txtTaiKhoan);
            this.panel2.Controls.Add(this.txttuoi);
            this.panel2.Controls.Add(this.siticoneButton3);
            this.panel2.Controls.Add(this.txtTrinhdo);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.siticoneButton1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.siticoneButton2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 345);
            this.panel2.TabIndex = 28;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton4.BorderRadius = 19;
            this.siticoneButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneButton4.Location = new System.Drawing.Point(826, 255);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.Size = new System.Drawing.Size(138, 43);
            this.siticoneButton4.TabIndex = 27;
            this.siticoneButton4.Text = "Xóa tài khoản";
            this.siticoneButton4.Click += new System.EventHandler(this.siticoneButton4_Click);
            // 
            // txtTaiKhoanID
            // 
            this.txtTaiKhoanID.Location = new System.Drawing.Point(195, 14);
            this.txtTaiKhoanID.Name = "txtTaiKhoanID";
            this.txtTaiKhoanID.Size = new System.Drawing.Size(100, 20);
            this.txtTaiKhoanID.TabIndex = 26;
            this.txtTaiKhoanID.Visible = false;
            // 
            // txtchuyenkhoaid
            // 
            this.txtchuyenkhoaid.Location = new System.Drawing.Point(-37, 14);
            this.txtchuyenkhoaid.Name = "txtchuyenkhoaid";
            this.txtchuyenkhoaid.Size = new System.Drawing.Size(100, 20);
            this.txtchuyenkhoaid.TabIndex = 20;
            this.txtchuyenkhoaid.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(789, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mật khẩu : ";
            // 
            // txtbacsiid
            // 
            this.txtbacsiid.Location = new System.Drawing.Point(77, 14);
            this.txtbacsiid.Name = "txtbacsiid";
            this.txtbacsiid.Size = new System.Drawing.Size(100, 20);
            this.txtbacsiid.TabIndex = 19;
            this.txtbacsiid.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tài khoản : ";
            // 
            // txtChucvu
            // 
            this.txtChucvu.Location = new System.Drawing.Point(178, 207);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(223, 20);
            this.txtChucvu.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(868, 122);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(223, 20);
            this.txtMatKhau.TabIndex = 23;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(527, 207);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(223, 20);
            this.txtChiPhi.TabIndex = 7;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(868, 78);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 20);
            this.txtTaiKhoan.TabIndex = 22;
            // 
            // txttuoi
            // 
            this.txttuoi.Location = new System.Drawing.Point(527, 78);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.Size = new System.Drawing.Size(223, 20);
            this.txttuoi.TabIndex = 4;
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BorderRadius = 19;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.Location = new System.Drawing.Point(395, 255);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.Size = new System.Drawing.Size(138, 43);
            this.siticoneButton3.TabIndex = 21;
            this.siticoneButton3.Text = "Thêm bác sỹ";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.Location = new System.Drawing.Point(178, 164);
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(223, 20);
            this.txtTrinhdo.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chuyenKhoaBindingSource;
            this.comboBox1.DisplayMember = "TenChuyenKhoa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ChuyenKhoaID";
            // 
            // chuyenKhoaBindingSource
            // 
            this.chuyenKhoaBindingSource.DataMember = "ChuyenKhoa";
            this.chuyenKhoaBindingSource.DataSource = this.quanLyLichKhamDataSet4;
            // 
            // quanLyLichKhamDataSet4
            // 
            this.quanLyLichKhamDataSet4.DataSetName = "QuanLyLichKhamDataSet4";
            this.quanLyLichKhamDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(527, 121);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(223, 20);
            this.txtsdt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chi phí khám : ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(178, 78);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(527, 164);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(223, 20);
            this.txtemail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số điện thoại :";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 19;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(178, 255);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(138, 43);
            this.siticoneButton1.TabIndex = 8;
            this.siticoneButton1.Text = "Sửa thông tin";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tuổi :";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BorderRadius = 19;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(612, 255);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(138, 43);
            this.siticoneButton2.TabIndex = 9;
            this.siticoneButton2.Text = "Xóa bác sỹ";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chức vụ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trình độ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chuyên khoa :";
            // 
            // chuyenKhoaTableAdapter
            // 
            this.chuyenKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachBacSy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDanhSachBacSy";
            this.Text = "frmDanhSachBacSy";
            this.Load += new System.EventHandler(this.frmDanhSachBacSy_Load);
            this.Resize += new System.EventHandler(this.frmDanhSachBacSy_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtTrinhdo;
        private System.Windows.Forms.TextBox txttuoi;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private QuanLyLichKhamDataSet4 quanLyLichKhamDataSet4;
        private System.Windows.Forms.BindingSource chuyenKhoaBindingSource;
        private QuanLyLichKhamDataSet4TableAdapters.ChuyenKhoaTableAdapter chuyenKhoaTableAdapter;
        private System.Windows.Forms.TextBox txtbacsiid;
        private System.Windows.Forms.TextBox txtchuyenkhoaid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaiKhoanID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private System.Windows.Forms.Panel panel2;
    }
}