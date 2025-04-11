namespace Second_Try.GUI.Admin
{
    partial class frmLich
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtGioden = new System.Windows.Forms.TextBox();
            this.dtpGiothucte = new System.Windows.Forms.DateTimePicker();
            this.txtLichhenid = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bacSiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyLichKhamDataSet5 = new Second_Try.QuanLyLichKhamDataSet5();
            this.txtBacsiid = new System.Windows.Forms.TextBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dtpngayhen = new System.Windows.Forms.DateTimePicker();
            this.btnDatlich = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbcCa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnHuy = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpGiohen = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
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
            this.quanLyLichKhamDataSet = new Second_Try.QuanLyLichKhamDataSet();
            this.quanLyLichKhamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bacSiTableAdapter = new Second_Try.QuanLyLichKhamDataSet5TableAdapters.BacSiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bacSiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtGioden);
            this.panel1.Controls.Add(this.dtpGiothucte);
            this.panel1.Controls.Add(this.txtLichhenid);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtBacsiid);
            this.panel1.Controls.Add(this.dateNgaysinh);
            this.panel1.Controls.Add(this.dtpngayhen);
            this.panel1.Controls.Add(this.btnDatlich);
            this.panel1.Controls.Add(this.cbcCa);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dtpGiohen);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.Nu);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.Nam);
            this.panel1.Controls.Add(this.txtTenBenhNhan);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 329);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Giờ đến :";
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(875, 209);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 17);
            this.checkBox3.TabIndex = 81;
            this.checkBox3.Text = "Đổi";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(419, 214);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 80;
            this.checkBox2.Text = "Chưa khám";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(299, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "Đã khám";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtGioden
            // 
            this.txtGioden.Location = new System.Drawing.Point(58, 193);
            this.txtGioden.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioden.Name = "txtGioden";
            this.txtGioden.Size = new System.Drawing.Size(76, 20);
            this.txtGioden.TabIndex = 78;
            this.txtGioden.Visible = false;
            // 
            // dtpGiothucte
            // 
            this.dtpGiothucte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGiothucte.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpGiothucte.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGiothucte.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpGiothucte.Location = new System.Drawing.Point(630, 208);
            this.dtpGiothucte.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGiothucte.Name = "dtpGiothucte";
            this.dtpGiothucte.ShowUpDown = true;
            this.dtpGiothucte.Size = new System.Drawing.Size(240, 20);
            this.dtpGiothucte.TabIndex = 77;
            this.dtpGiothucte.ValueChanged += new System.EventHandler(this.dtpGiothucte_ValueChanged);
            // 
            // txtLichhenid
            // 
            this.txtLichhenid.Location = new System.Drawing.Point(58, 108);
            this.txtLichhenid.Margin = new System.Windows.Forms.Padding(2);
            this.txtLichhenid.Name = "txtLichhenid";
            this.txtLichhenid.Size = new System.Drawing.Size(76, 20);
            this.txtLichhenid.TabIndex = 76;
            this.txtLichhenid.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.bacSiBindingSource;
            this.comboBox1.DisplayMember = "HoTen";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(630, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.ValueMember = "BacSiID";
            // 
            // bacSiBindingSource
            // 
            this.bacSiBindingSource.DataMember = "BacSi";
            this.bacSiBindingSource.DataSource = this.quanLyLichKhamDataSet5;
            // 
            // quanLyLichKhamDataSet5
            // 
            this.quanLyLichKhamDataSet5.DataSetName = "QuanLyLichKhamDataSet5";
            this.quanLyLichKhamDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBacsiid
            // 
            this.txtBacsiid.Location = new System.Drawing.Point(58, 150);
            this.txtBacsiid.Margin = new System.Windows.Forms.Padding(2);
            this.txtBacsiid.Name = "txtBacsiid";
            this.txtBacsiid.Size = new System.Drawing.Size(76, 20);
            this.txtBacsiid.TabIndex = 74;
            this.txtBacsiid.Visible = false;
            this.txtBacsiid.TextChanged += new System.EventHandler(this.txtBacsiid_TextChanged);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNgaysinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaysinh.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateNgaysinh.Location = new System.Drawing.Point(299, 89);
            this.dateNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.ShowUpDown = true;
            this.dateNgaysinh.Size = new System.Drawing.Size(151, 20);
            this.dateNgaysinh.TabIndex = 73;
            // 
            // dtpngayhen
            // 
            this.dtpngayhen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpngayhen.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpngayhen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayhen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpngayhen.Location = new System.Drawing.Point(630, 89);
            this.dtpngayhen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpngayhen.Name = "dtpngayhen";
            this.dtpngayhen.ShowUpDown = true;
            this.dtpngayhen.Size = new System.Drawing.Size(151, 20);
            this.dtpngayhen.TabIndex = 72;
            // 
            // btnDatlich
            // 
            this.btnDatlich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatlich.BorderRadius = 19;
            this.btnDatlich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatlich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatlich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatlich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatlich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatlich.ForeColor = System.Drawing.Color.White;
            this.btnDatlich.Location = new System.Drawing.Point(321, 249);
            this.btnDatlich.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatlich.Name = "btnDatlich";
            this.btnDatlich.Size = new System.Drawing.Size(135, 37);
            this.btnDatlich.TabIndex = 65;
            this.btnDatlich.Text = "Sửa lịch";
            this.btnDatlich.Click += new System.EventHandler(this.btnDatlich_Click);
            // 
            // cbcCa
            // 
            this.cbcCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbcCa.FormattingEnabled = true;
            this.cbcCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbcCa.Location = new System.Drawing.Point(785, 114);
            this.cbcCa.Margin = new System.Windows.Forms.Padding(2);
            this.cbcCa.Name = "cbcCa";
            this.cbcCa.Size = new System.Drawing.Size(92, 21);
            this.cbcCa.TabIndex = 71;
            this.cbcCa.SelectedIndexChanged += new System.EventHandler(this.cbcCa_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 61);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Tên bệnh nhân :";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BorderRadius = 19;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(574, 249);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 37);
            this.btnHuy.TabIndex = 70;
            this.btnHuy.Text = "Hủy lịch";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 89);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Ngày sinh :";
            // 
            // dtpGiohen
            // 
            this.dtpGiohen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGiohen.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpGiohen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGiohen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpGiohen.Location = new System.Drawing.Point(630, 115);
            this.dtpGiohen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGiohen.Name = "dtpGiohen";
            this.dtpGiohen.ShowUpDown = true;
            this.dtpGiohen.Size = new System.Drawing.Size(151, 20);
            this.dtpGiohen.TabIndex = 69;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(206, 121);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Giới tính :";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(206, 153);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Số điện thoại :";
            // 
            // Nu
            // 
            this.Nu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nu.AutoSize = true;
            this.Nu.Location = new System.Drawing.Point(422, 121);
            this.Nu.Margin = new System.Windows.Forms.Padding(2);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(40, 17);
            this.Nu.TabIndex = 67;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(208, 184);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Địa chỉ :";
            // 
            // Nam
            // 
            this.Nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(299, 121);
            this.Nam.Margin = new System.Windows.Forms.Padding(2);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(48, 17);
            this.Nam.TabIndex = 66;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenBenhNhan.Location = new System.Drawing.Point(299, 56);
            this.txtTenBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(200, 20);
            this.txtTenBenhNhan.TabIndex = 57;
            // 
            // txtghichu
            // 
            this.txtghichu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtghichu.Location = new System.Drawing.Point(630, 148);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(240, 56);
            this.txtghichu.TabIndex = 64;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSdt.Location = new System.Drawing.Point(299, 148);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(200, 20);
            this.txtSdt.TabIndex = 58;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(546, 148);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 63;
            this.label30.Text = "Ghi chú :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiachi.Location = new System.Drawing.Point(299, 179);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 20);
            this.txtDiachi.TabIndex = 59;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(543, 115);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 62;
            this.label29.Text = "Thời gian :";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(546, 63);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "Bác sỹ :";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(545, 87);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 13);
            this.label28.TabIndex = 61;
            this.label28.Text = "Ngày hẹn :";
            // 
            // quanLyLichKhamDataSet
            // 
            this.quanLyLichKhamDataSet.DataSetName = "QuanLyLichKhamDataSet";
            this.quanLyLichKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyLichKhamDataSetBindingSource
            // 
            this.quanLyLichKhamDataSetBindingSource.DataSource = this.quanLyLichKhamDataSet;
            this.quanLyLichKhamDataSetBindingSource.Position = 0;
            // 
            // bacSiTableAdapter
            // 
            this.bacSiTableAdapter.ClearBeforeFill = true;
            // 
            // frmLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLich";
            this.Text = "frmLich";
            this.Load += new System.EventHandler(this.frmLich_Load);
            this.Resize += new System.EventHandler(this.frmLich_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bacSiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBacsiid;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.DateTimePicker dtpngayhen;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDatlich;
        private System.Windows.Forms.ComboBox cbcCa;
        private System.Windows.Forms.Label label15;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnHuy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpGiohen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox Nu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox Nam;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private QuanLyLichKhamDataSet quanLyLichKhamDataSet;
        private System.Windows.Forms.BindingSource quanLyLichKhamDataSetBindingSource;
        private QuanLyLichKhamDataSet5 quanLyLichKhamDataSet5;
        private System.Windows.Forms.BindingSource bacSiBindingSource;
        private QuanLyLichKhamDataSet5TableAdapters.BacSiTableAdapter bacSiTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtLichhenid;
        private System.Windows.Forms.DateTimePicker dtpGiothucte;
        private System.Windows.Forms.TextBox txtGioden;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
    }
}