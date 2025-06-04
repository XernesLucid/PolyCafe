using Guna.UI2.WinForms;

namespace GUI_PolyCafe
{
    partial class frmPhieuBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPhieuBanHang = new System.Windows.Forms.TabPage();
            this.btnXoaChiTiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaChiTiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemChiTiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLamMoiPhieu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaPhieu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaPhieu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemPhieu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.rdoDaThanhToan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoChoXacNhan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboThe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChiTietPhieu = new System.Windows.Forms.GroupBox();
            this.cboSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPhieuChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabChiTietPhieu = new System.Windows.Forms.TabPage();
            this.dgvPhieuBanHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPhieuBanHang.SuspendLayout();
            this.grpThongTinPhieu.SuspendLayout();
            this.grpChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiTiet)).BeginInit();
            this.tabChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPhieuBanHang);
            this.tabControl1.Controls.Add(this.tabChiTietPhieu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1752, 920);
            this.tabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPhieuBanHang
            // 
            this.tabPhieuBanHang.Controls.Add(this.btnXoaChiTiet);
            this.tabPhieuBanHang.Controls.Add(this.btnSuaChiTiet);
            this.tabPhieuBanHang.Controls.Add(this.btnThemChiTiet);
            this.tabPhieuBanHang.Controls.Add(this.btnThanhToan);
            this.tabPhieuBanHang.Controls.Add(this.btnLamMoiPhieu);
            this.tabPhieuBanHang.Controls.Add(this.btnXoaPhieu);
            this.tabPhieuBanHang.Controls.Add(this.btnSuaPhieu);
            this.tabPhieuBanHang.Controls.Add(this.btnThemPhieu);
            this.tabPhieuBanHang.Controls.Add(this.lblTitle);
            this.tabPhieuBanHang.Controls.Add(this.grpThongTinPhieu);
            this.tabPhieuBanHang.Controls.Add(this.grpChiTietPhieu);
            this.tabPhieuBanHang.Controls.Add(this.dgvPhieuChiTiet);
            this.tabPhieuBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tabPhieuBanHang.Location = new System.Drawing.Point(184, 4);
            this.tabPhieuBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPhieuBanHang.Name = "tabPhieuBanHang";
            this.tabPhieuBanHang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPhieuBanHang.Size = new System.Drawing.Size(1564, 912);
            this.tabPhieuBanHang.TabIndex = 0;
            this.tabPhieuBanHang.Text = "Phiếu bán hàng";
            this.tabPhieuBanHang.UseVisualStyleBackColor = true;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Animated = true;
            this.btnXoaChiTiet.BorderRadius = 10;
            this.btnXoaChiTiet.BorderThickness = 3;
            this.btnXoaChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaChiTiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaChiTiet.FillColor = System.Drawing.Color.Maroon;
            this.btnXoaChiTiet.FillColor2 = System.Drawing.Color.Red;
            this.btnXoaChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoaChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(1384, 347);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(155, 50);
            this.btnXoaChiTiet.TabIndex = 42;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.Animated = true;
            this.btnSuaChiTiet.BorderRadius = 10;
            this.btnSuaChiTiet.BorderThickness = 3;
            this.btnSuaChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaChiTiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaChiTiet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSuaChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnSuaChiTiet.Location = new System.Drawing.Point(1199, 347);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(155, 50);
            this.btnSuaChiTiet.TabIndex = 41;
            this.btnSuaChiTiet.Text = "Sửa";
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Animated = true;
            this.btnThemChiTiet.BorderRadius = 10;
            this.btnThemChiTiet.BorderThickness = 3;
            this.btnThemChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemChiTiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemChiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemChiTiet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnThemChiTiet.Location = new System.Drawing.Point(1016, 347);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(155, 50);
            this.btnThemChiTiet.TabIndex = 40;
            this.btnThemChiTiet.Text = "Thêm";
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Animated = true;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.BorderThickness = 3;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.FillColor2 = System.Drawing.Color.Lime;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(782, 347);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(213, 50);
            this.btnThanhToan.TabIndex = 39;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoiPhieu
            // 
            this.btnLamMoiPhieu.Animated = true;
            this.btnLamMoiPhieu.BorderRadius = 10;
            this.btnLamMoiPhieu.BorderThickness = 3;
            this.btnLamMoiPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiPhieu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLamMoiPhieu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLamMoiPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiPhieu.Location = new System.Drawing.Point(336, 347);
            this.btnLamMoiPhieu.Name = "btnLamMoiPhieu";
            this.btnLamMoiPhieu.Size = new System.Drawing.Size(142, 50);
            this.btnLamMoiPhieu.TabIndex = 38;
            this.btnLamMoiPhieu.Text = "Làm Mới";
            this.btnLamMoiPhieu.Click += new System.EventHandler(this.btnLamMoiPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Animated = true;
            this.btnXoaPhieu.BorderRadius = 10;
            this.btnXoaPhieu.BorderThickness = 3;
            this.btnXoaPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPhieu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaPhieu.FillColor = System.Drawing.Color.Maroon;
            this.btnXoaPhieu.FillColor2 = System.Drawing.Color.Red;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Location = new System.Drawing.Point(492, 347);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(142, 50);
            this.btnXoaPhieu.TabIndex = 37;
            this.btnXoaPhieu.Text = "Xóa";
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.Animated = true;
            this.btnSuaPhieu.BorderRadius = 10;
            this.btnSuaPhieu.BorderThickness = 3;
            this.btnSuaPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaPhieu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaPhieu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSuaPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhieu.Location = new System.Drawing.Point(178, 347);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(142, 50);
            this.btnSuaPhieu.TabIndex = 36;
            this.btnSuaPhieu.Text = "Sửa";
            this.btnSuaPhieu.Click += new System.EventHandler(this.btnSuaPhieu_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Animated = true;
            this.btnThemPhieu.BorderRadius = 10;
            this.btnThemPhieu.BorderThickness = 3;
            this.btnThemPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhieu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemPhieu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieu.Location = new System.Drawing.Point(22, 347);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(142, 50);
            this.btnThemPhieu.TabIndex = 34;
            this.btnThemPhieu.Text = "Thêm";
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(626, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 54);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "PHIẾU BÁN HÀNG";
            // 
            // grpThongTinPhieu
            // 
            this.grpThongTinPhieu.Controls.Add(this.rdoDaThanhToan);
            this.grpThongTinPhieu.Controls.Add(this.rdoChoXacNhan);
            this.grpThongTinPhieu.Controls.Add(this.label5);
            this.grpThongTinPhieu.Controls.Add(this.dtpNgayTao);
            this.grpThongTinPhieu.Controls.Add(this.label4);
            this.grpThongTinPhieu.Controls.Add(this.cboNhanVien);
            this.grpThongTinPhieu.Controls.Add(this.label3);
            this.grpThongTinPhieu.Controls.Add(this.cboThe);
            this.grpThongTinPhieu.Controls.Add(this.label2);
            this.grpThongTinPhieu.Controls.Add(this.txtMaPhieu);
            this.grpThongTinPhieu.Controls.Add(this.label1);
            this.grpThongTinPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinPhieu.Location = new System.Drawing.Point(22, 71);
            this.grpThongTinPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinPhieu.Name = "grpThongTinPhieu";
            this.grpThongTinPhieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinPhieu.Size = new System.Drawing.Size(973, 258);
            this.grpThongTinPhieu.TabIndex = 0;
            this.grpThongTinPhieu.TabStop = false;
            this.grpThongTinPhieu.Text = "Thông tin Phiếu";
            // 
            // rdoDaThanhToan
            // 
            this.rdoDaThanhToan.CheckedState.BorderThickness = 0;
            this.rdoDaThanhToan.Location = new System.Drawing.Point(526, 201);
            this.rdoDaThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDaThanhToan.Name = "rdoDaThanhToan";
            this.rdoDaThanhToan.Size = new System.Drawing.Size(259, 36);
            this.rdoDaThanhToan.TabIndex = 0;
            this.rdoDaThanhToan.Text = "Đã thanh toán";
            this.rdoDaThanhToan.UncheckedState.BorderThickness = 0;
            // 
            // rdoChoXacNhan
            // 
            this.rdoChoXacNhan.CheckedState.BorderThickness = 0;
            this.rdoChoXacNhan.Location = new System.Drawing.Point(200, 197);
            this.rdoChoXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.rdoChoXacNhan.Name = "rdoChoXacNhan";
            this.rdoChoXacNhan.Size = new System.Drawing.Size(256, 40);
            this.rdoChoXacNhan.TabIndex = 1;
            this.rdoChoXacNhan.Text = "Chờ xác nhận";
            this.rdoChoXacNhan.UncheckedState.BorderThickness = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Trạng Thái:";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.BorderRadius = 10;
            this.dtpNgayTao.BorderThickness = 2;
            this.dtpNgayTao.Checked = true;
            this.dtpNgayTao.FillColor = System.Drawing.Color.White;
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(655, 121);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(283, 37);
            this.dtpNgayTao.TabIndex = 3;
            this.dtpNgayTao.Value = new System.DateTime(2025, 5, 30, 10, 12, 15, 53);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Tạo:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVien.BorderColor = System.Drawing.Color.Black;
            this.cboNhanVien.BorderRadius = 10;
            this.cboNhanVien.BorderThickness = 2;
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNhanVien.ItemHeight = 30;
            this.cboNhanVien.Location = new System.Drawing.Point(199, 117);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(287, 36);
            this.cboNhanVien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // cboThe
            // 
            this.cboThe.BackColor = System.Drawing.Color.Transparent;
            this.cboThe.BorderColor = System.Drawing.Color.Black;
            this.cboThe.BorderRadius = 10;
            this.cboThe.BorderThickness = 2;
            this.cboThe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThe.FocusedColor = System.Drawing.Color.Empty;
            this.cboThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThe.ItemHeight = 30;
            this.cboThe.Location = new System.Drawing.Point(655, 33);
            this.cboThe.Margin = new System.Windows.Forms.Padding(4);
            this.cboThe.Name = "cboThe";
            this.cboThe.Size = new System.Drawing.Size(283, 36);
            this.cboThe.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Thẻ:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.BorderColor = System.Drawing.Color.Black;
            this.txtMaPhieu.BorderRadius = 10;
            this.txtMaPhieu.BorderThickness = 2;
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.DefaultText = "";
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(199, 35);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PlaceholderText = "";
            this.txtMaPhieu.SelectedText = "";
            this.txtMaPhieu.Size = new System.Drawing.Size(287, 38);
            this.txtMaPhieu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phiếu:";
            // 
            // grpChiTietPhieu
            // 
            this.grpChiTietPhieu.Controls.Add(this.cboSanPham);
            this.grpChiTietPhieu.Controls.Add(this.label7);
            this.grpChiTietPhieu.Controls.Add(this.txtDonGia);
            this.grpChiTietPhieu.Controls.Add(this.label8);
            this.grpChiTietPhieu.Controls.Add(this.txtSoLuong);
            this.grpChiTietPhieu.Controls.Add(this.label9);
            this.grpChiTietPhieu.Controls.Add(this.txtThanhTien);
            this.grpChiTietPhieu.Controls.Add(this.label10);
            this.grpChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChiTietPhieu.Location = new System.Drawing.Point(1016, 71);
            this.grpChiTietPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.grpChiTietPhieu.Name = "grpChiTietPhieu";
            this.grpChiTietPhieu.Padding = new System.Windows.Forms.Padding(4);
            this.grpChiTietPhieu.Size = new System.Drawing.Size(523, 258);
            this.grpChiTietPhieu.TabIndex = 1;
            this.grpChiTietPhieu.TabStop = false;
            this.grpChiTietPhieu.Text = "Chi Tiết Phiếu";
            // 
            // cboSanPham
            // 
            this.cboSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cboSanPham.BorderColor = System.Drawing.Color.Black;
            this.cboSanPham.BorderRadius = 10;
            this.cboSanPham.BorderThickness = 2;
            this.cboSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSanPham.ItemHeight = 30;
            this.cboSanPham.Location = new System.Drawing.Point(192, 31);
            this.cboSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(297, 36);
            this.cboSanPham.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sản Phẩm:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.Black;
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.BorderThickness = 2;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonGia.Location = new System.Drawing.Point(192, 86);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(297, 38);
            this.txtDonGia.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đơn Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.Black;
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.BorderThickness = 2;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(192, 138);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(297, 38);
            this.txtSoLuong.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số Lượng:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderColor = System.Drawing.Color.Black;
            this.txtThanhTien.BorderRadius = 10;
            this.txtThanhTien.BorderThickness = 2;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThanhTien.Location = new System.Drawing.Point(192, 197);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(297, 36);
            this.txtThanhTien.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Thành Tiền:";
            // 
            // dgvPhieuChiTiet
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvPhieuChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPhieuChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPhieuChiTiet.ColumnHeadersHeight = 34;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuChiTiet.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPhieuChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuChiTiet.Location = new System.Drawing.Point(9, 424);
            this.dgvPhieuChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuChiTiet.Name = "dgvPhieuChiTiet";
            this.dgvPhieuChiTiet.RowHeadersVisible = false;
            this.dgvPhieuChiTiet.RowHeadersWidth = 62;
            this.dgvPhieuChiTiet.Size = new System.Drawing.Size(1551, 484);
            this.dgvPhieuChiTiet.TabIndex = 10;
            this.dgvPhieuChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuChiTiet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhieuChiTiet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhieuChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuChiTiet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuChiTiet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuChiTiet.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvPhieuChiTiet.ThemeStyle.ReadOnly = false;
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuChiTiet_CellClick);
            // 
            // tabChiTietPhieu
            // 
            this.tabChiTietPhieu.Controls.Add(this.dgvPhieuBanHang);
            this.tabChiTietPhieu.Location = new System.Drawing.Point(184, 4);
            this.tabChiTietPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.tabChiTietPhieu.Name = "tabChiTietPhieu";
            this.tabChiTietPhieu.Padding = new System.Windows.Forms.Padding(4);
            this.tabChiTietPhieu.Size = new System.Drawing.Size(1564, 912);
            this.tabChiTietPhieu.TabIndex = 1;
            this.tabChiTietPhieu.Text = "Danh sách phiếu";
            this.tabChiTietPhieu.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuBanHang
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvPhieuBanHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPhieuBanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuBanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPhieuBanHang.ColumnHeadersHeight = 34;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuBanHang.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPhieuBanHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuBanHang.Location = new System.Drawing.Point(4, 4);
            this.dgvPhieuBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuBanHang.Name = "dgvPhieuBanHang";
            this.dgvPhieuBanHang.RowHeadersVisible = false;
            this.dgvPhieuBanHang.RowHeadersWidth = 62;
            this.dgvPhieuBanHang.Size = new System.Drawing.Size(1556, 899);
            this.dgvPhieuBanHang.TabIndex = 11;
            this.dgvPhieuBanHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuBanHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhieuBanHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuBanHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhieuBanHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuBanHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuBanHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuBanHang.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvPhieuBanHang.ThemeStyle.ReadOnly = false;
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuBanHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuBanHang_CellClick);
            // 
            // frmPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 920);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuBanHang";
            this.Text = "Quản Lý Phiếu Bán Hàng";
            this.tabControl1.ResumeLayout(false);
            this.tabPhieuBanHang.ResumeLayout(false);
            this.tabPhieuBanHang.PerformLayout();
            this.grpThongTinPhieu.ResumeLayout(false);
            this.grpThongTinPhieu.PerformLayout();
            this.grpChiTietPhieu.ResumeLayout(false);
            this.grpChiTietPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiTiet)).EndInit();
            this.tabChiTietPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhieuBanHang;
        private System.Windows.Forms.TabPage tabChiTietPhieu;
        private System.Windows.Forms.GroupBox grpThongTinPhieu;
        private System.Windows.Forms.Label label1;
        private Guna2TextBox txtMaPhieu;
        private System.Windows.Forms.Label label2;
        private Guna2ComboBox cboThe;
        private System.Windows.Forms.Label label3;
        private Guna2ComboBox cboNhanVien;
        private System.Windows.Forms.Label label4;
        private Guna2DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label5;
        private Guna2RadioButton rdoChoXacNhan;
        private Guna2RadioButton rdoDaThanhToan;
        private System.Windows.Forms.GroupBox grpChiTietPhieu;
        private System.Windows.Forms.Label label7;
        private Guna2ComboBox cboSanPham;
        private System.Windows.Forms.Label label8;
        private Guna2TextBox txtDonGia;
        private System.Windows.Forms.Label label9;
        private Guna2TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private Guna2TextBox txtThanhTien;
        private Guna2DataGridView dgvPhieuChiTiet;
        private System.Windows.Forms.Label lblTitle;
        private Guna2GradientButton btnThemPhieu;
        private Guna2GradientButton btnSuaPhieu;
        private Guna2GradientButton btnXoaPhieu;
        private Guna2GradientButton btnThanhToan;
        private Guna2GradientButton btnLamMoiPhieu;
        private Guna2GradientButton btnXoaChiTiet;
        private Guna2GradientButton btnSuaChiTiet;
        private Guna2GradientButton btnThemChiTiet;
        private Guna2DataGridView dgvPhieuBanHang;
    }
}