namespace Second_Try.View
{
    partial class frmLichHen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBacsiid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDatlich = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbcCa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTenbacsi = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Nu = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Nam = new System.Windows.Forms.CheckBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtBacsiid);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dateNgaysinh);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.btnDatlich);
            this.panel2.Controls.Add(this.cbcCa);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblTenbacsi);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.Nu);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.Nam);
            this.panel2.Controls.Add(this.txtTenBenhNhan);
            this.panel2.Controls.Add(this.txtghichu);
            this.panel2.Controls.Add(this.txtSdt);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 647);
            this.panel2.TabIndex = 49;
            // 
            // txtBacsiid
            // 
            this.txtBacsiid.Location = new System.Drawing.Point(1030, 302);
            this.txtBacsiid.Name = "txtBacsiid";
            this.txtBacsiid.Size = new System.Drawing.Size(100, 22);
            this.txtBacsiid.TabIndex = 51;
            this.txtBacsiid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgaysinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaysinh.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateNgaysinh.Location = new System.Drawing.Point(273, 362);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.ShowUpDown = true;
            this.dateNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dateNgaysinh.TabIndex = 50;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker2.Location = new System.Drawing.Point(714, 362);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 48;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnDatlich
            // 
            this.btnDatlich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDatlich.BorderRadius = 19;
            this.btnDatlich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatlich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatlich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatlich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatlich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatlich.ForeColor = System.Drawing.Color.White;
            this.btnDatlich.Location = new System.Drawing.Point(303, 559);
            this.btnDatlich.Name = "btnDatlich";
            this.btnDatlich.Size = new System.Drawing.Size(180, 45);
            this.btnDatlich.TabIndex = 40;
            this.btnDatlich.Text = "Sửa lịch";
            this.btnDatlich.Click += new System.EventHandler(this.btnDatlich_Click);
            // 
            // cbcCa
            // 
            this.cbcCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbcCa.FormattingEnabled = true;
            this.cbcCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbcCa.Location = new System.Drawing.Point(957, 393);
            this.cbcCa.Name = "cbcCa";
            this.cbcCa.Size = new System.Drawing.Size(121, 24);
            this.cbcCa.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Tên bệnh nhân :";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BorderRadius = 19;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(640, 559);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 45);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy lịch";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(149, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Ngày sinh :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(714, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(149, 401);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "Giới tính :";
            // 
            // lblTenbacsi
            // 
            this.lblTenbacsi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenbacsi.AutoSize = true;
            this.lblTenbacsi.Location = new System.Drawing.Point(720, 330);
            this.lblTenbacsi.Name = "lblTenbacsi";
            this.lblTenbacsi.Size = new System.Drawing.Size(51, 16);
            this.lblTenbacsi.TabIndex = 43;
            this.lblTenbacsi.Text = "label31";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(149, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Số điện thoại :";
            // 
            // Nu
            // 
            this.Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nu.AutoSize = true;
            this.Nu.Location = new System.Drawing.Point(437, 401);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(46, 20);
            this.Nu.TabIndex = 42;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            this.Nu.CheckedChanged += new System.EventHandler(this.Nu_CheckedChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(152, 479);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 16);
            this.label21.TabIndex = 30;
            this.label21.Text = "Địa chỉ :";
            // 
            // Nam
            // 
            this.Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(273, 401);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(58, 20);
            this.Nam.TabIndex = 41;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            this.Nam.CheckedChanged += new System.EventHandler(this.Nam_CheckedChanged);
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenBenhNhan.Location = new System.Drawing.Point(273, 321);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(265, 22);
            this.txtTenBenhNhan.TabIndex = 31;
            // 
            // txtghichu
            // 
            this.txtghichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtghichu.Location = new System.Drawing.Point(714, 434);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(319, 68);
            this.txtghichu.TabIndex = 39;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSdt.Location = new System.Drawing.Point(273, 434);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(265, 22);
            this.txtSdt.TabIndex = 33;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(598, 427);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 16);
            this.label30.TabIndex = 38;
            this.label30.Text = "Ghi chú :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachi.Location = new System.Drawing.Point(273, 473);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(265, 22);
            this.txtDiachi.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(599, 394);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 16);
            this.label29.TabIndex = 37;
            this.label29.Text = "Thời gian :";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(602, 330);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 16);
            this.label27.TabIndex = 35;
            this.label27.Text = "Bác sỹ :";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(601, 360);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 16);
            this.label28.TabIndex = 36;
            this.label28.Text = "Ngày hẹn :";
            // 
            // frmLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 647);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLichHen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTenbacsi;
        private System.Windows.Forms.CheckBox Nu;
        private System.Windows.Forms.CheckBox Nam;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDatlich;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbcCa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBacsiid;
    }
}