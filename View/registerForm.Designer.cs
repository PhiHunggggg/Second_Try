namespace Second_Try
{
    partial class registerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLoaitaikhoan = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNhap_lai_mk = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMat_khau = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtTen_dang_nhap = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(135, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbLoaitaikhoan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtNhap_lai_mk);
            this.panel1.Controls.Add(this.txtMat_khau);
            this.panel1.Controls.Add(this.txtTen_dang_nhap);
            this.panel1.Controls.Add(this.siticonePictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 692);
            this.panel1.TabIndex = 2;
            // 
            // cmbLoaitaikhoan
            // 
            this.cmbLoaitaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaitaikhoan.BorderRadius = 19;
            this.cmbLoaitaikhoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaitaikhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaitaikhoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaitaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaitaikhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaitaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaitaikhoan.ItemHeight = 30;
            this.cmbLoaitaikhoan.Items.AddRange(new object[] {
            "Bác Sỹ",
            "Bệnh nhân"});
            this.cmbLoaitaikhoan.Location = new System.Drawing.Point(136, 393);
            this.cmbLoaitaikhoan.Name = "cmbLoaitaikhoan";
            this.cmbLoaitaikhoan.Size = new System.Drawing.Size(428, 36);
            this.cmbLoaitaikhoan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Already a member?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(264, 591);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 14;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(136, 488);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(428, 54);
            this.siticoneButton1.TabIndex = 10;
            this.siticoneButton1.Text = "Submit";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(143, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "I accept the Term of Use";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNhap_lai_mk
            // 
            this.txtNhap_lai_mk.BorderRadius = 20;
            this.txtNhap_lai_mk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhap_lai_mk.DefaultText = "";
            this.txtNhap_lai_mk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhap_lai_mk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhap_lai_mk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhap_lai_mk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhap_lai_mk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhap_lai_mk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhap_lai_mk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhap_lai_mk.Location = new System.Drawing.Point(136, 329);
            this.txtNhap_lai_mk.Name = "txtNhap_lai_mk";
            this.txtNhap_lai_mk.PasswordChar = '\0';
            this.txtNhap_lai_mk.PlaceholderText = "";
            this.txtNhap_lai_mk.SelectedText = "";
            this.txtNhap_lai_mk.Size = new System.Drawing.Size(428, 38);
            this.txtNhap_lai_mk.TabIndex = 6;
            this.txtNhap_lai_mk.Click += new System.EventHandler(this.txtNhap_lai_mk_Click);
            this.txtNhap_lai_mk.Enter += new System.EventHandler(this.txtNhap_lai_mk_Enter);
            this.txtNhap_lai_mk.Leave += new System.EventHandler(this.txtNhap_lai_mk_Leave);
            // 
            // txtMat_khau
            // 
            this.txtMat_khau.BorderRadius = 20;
            this.txtMat_khau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMat_khau.DefaultText = "";
            this.txtMat_khau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMat_khau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMat_khau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMat_khau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMat_khau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMat_khau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMat_khau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMat_khau.Location = new System.Drawing.Point(136, 268);
            this.txtMat_khau.Name = "txtMat_khau";
            this.txtMat_khau.PasswordChar = '\0';
            this.txtMat_khau.PlaceholderText = "";
            this.txtMat_khau.SelectedText = "";
            this.txtMat_khau.Size = new System.Drawing.Size(428, 38);
            this.txtMat_khau.TabIndex = 5;
            this.txtMat_khau.Click += new System.EventHandler(this.txtMat_khau_Click);
            this.txtMat_khau.Enter += new System.EventHandler(this.txtMat_khau_Enter);
            this.txtMat_khau.Leave += new System.EventHandler(this.txtMat_khau_Leave);
            // 
            // txtTen_dang_nhap
            // 
            this.txtTen_dang_nhap.BorderRadius = 20;
            this.txtTen_dang_nhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen_dang_nhap.DefaultText = "";
            this.txtTen_dang_nhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen_dang_nhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen_dang_nhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen_dang_nhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen_dang_nhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen_dang_nhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTen_dang_nhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen_dang_nhap.Location = new System.Drawing.Point(136, 207);
            this.txtTen_dang_nhap.Name = "txtTen_dang_nhap";
            this.txtTen_dang_nhap.PasswordChar = '\0';
            this.txtTen_dang_nhap.PlaceholderText = "";
            this.txtTen_dang_nhap.SelectedText = "";
            this.txtTen_dang_nhap.Size = new System.Drawing.Size(428, 38);
            this.txtTen_dang_nhap.TabIndex = 4;
            this.txtTen_dang_nhap.TextChanged += new System.EventHandler(this.txtTen_dang_nhap_TextChanged);
            this.txtTen_dang_nhap.Click += new System.EventHandler(this.txtTen_dang_nhap_Click);
            this.txtTen_dang_nhap.Enter += new System.EventHandler(this.txtTen_dang_nhap_Enter);
            this.txtTen_dang_nhap.Leave += new System.EventHandler(this.txtTen_dang_nhap_Leave);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::Second_Try.Properties.Resources.đăng_ký;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(661, 99);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(539, 508);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 3;
            this.siticonePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(138, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please fill in this form to create new account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 692);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNhap_lai_mk;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMat_khau;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTen_dang_nhap;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbLoaitaikhoan;
    }
}