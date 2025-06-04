namespace GUI_PolyCafe
{
    partial class frmDoiMatKhau
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chkHienThi1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkHienThi2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkHienThi3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtMKcu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMKmoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(452, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(319, 46);
            this.label.TabIndex = 0;
            this.label.Text = "ĐỔI MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Animated = true;
            this.btnDoiMatKhau.BorderRadius = 20;
            this.btnDoiMatKhau.BorderThickness = 3;
            this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(161, 620);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(274, 66);
            this.btnDoiMatKhau.TabIndex = 30;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderThickness = 3;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(601, 620);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(274, 66);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            // 
            // chkHienThi1
            // 
            this.chkHienThi1.AutoSize = true;
            this.chkHienThi1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi1.CheckedState.BorderRadius = 0;
            this.chkHienThi1.CheckedState.BorderThickness = 0;
            this.chkHienThi1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkHienThi1.Location = new System.Drawing.Point(902, 312);
            this.chkHienThi1.Name = "chkHienThi1";
            this.chkHienThi1.Size = new System.Drawing.Size(120, 33);
            this.chkHienThi1.TabIndex = 32;
            this.chkHienThi1.Text = "Hiển thị";
            this.chkHienThi1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi1.UncheckedState.BorderRadius = 0;
            this.chkHienThi1.UncheckedState.BorderThickness = 0;
            this.chkHienThi1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi1.CheckedChanged += new System.EventHandler(this.chkHienThi1_CheckedChanged);
            // 
            // chkHienThi2
            // 
            this.chkHienThi2.AutoSize = true;
            this.chkHienThi2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi2.CheckedState.BorderRadius = 0;
            this.chkHienThi2.CheckedState.BorderThickness = 0;
            this.chkHienThi2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkHienThi2.Location = new System.Drawing.Point(902, 418);
            this.chkHienThi2.Name = "chkHienThi2";
            this.chkHienThi2.Size = new System.Drawing.Size(120, 33);
            this.chkHienThi2.TabIndex = 33;
            this.chkHienThi2.Text = "Hiển thị";
            this.chkHienThi2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi2.UncheckedState.BorderRadius = 0;
            this.chkHienThi2.UncheckedState.BorderThickness = 0;
            this.chkHienThi2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi2.CheckedChanged += new System.EventHandler(this.chkHienThi2_CheckedChanged);
            // 
            // chkHienThi3
            // 
            this.chkHienThi3.AutoSize = true;
            this.chkHienThi3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi3.CheckedState.BorderRadius = 0;
            this.chkHienThi3.CheckedState.BorderThickness = 0;
            this.chkHienThi3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienThi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkHienThi3.Location = new System.Drawing.Point(902, 522);
            this.chkHienThi3.Name = "chkHienThi3";
            this.chkHienThi3.Size = new System.Drawing.Size(120, 33);
            this.chkHienThi3.TabIndex = 34;
            this.chkHienThi3.Text = "Hiển thị";
            this.chkHienThi3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi3.UncheckedState.BorderRadius = 0;
            this.chkHienThi3.UncheckedState.BorderThickness = 0;
            this.chkHienThi3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThi3.CheckedChanged += new System.EventHandler(this.chkHienThi3_CheckedChanged);
            // 
            // txtMKcu
            // 
            this.txtMKcu.Animated = true;
            this.txtMKcu.BorderColor = System.Drawing.Color.Black;
            this.txtMKcu.BorderRadius = 10;
            this.txtMKcu.BorderThickness = 2;
            this.txtMKcu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKcu.DefaultText = "";
            this.txtMKcu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKcu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKcu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKcu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKcu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKcu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMKcu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKcu.Location = new System.Drawing.Point(318, 310);
            this.txtMKcu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.PlaceholderText = "";
            this.txtMKcu.SelectedText = "";
            this.txtMKcu.Size = new System.Drawing.Size(550, 42);
            this.txtMKcu.TabIndex = 35;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Animated = true;
            this.txtMKmoi.BorderColor = System.Drawing.Color.Black;
            this.txtMKmoi.BorderRadius = 10;
            this.txtMKmoi.BorderThickness = 2;
            this.txtMKmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKmoi.DefaultText = "";
            this.txtMKmoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKmoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKmoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKmoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKmoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKmoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMKmoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKmoi.Location = new System.Drawing.Point(318, 409);
            this.txtMKmoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PlaceholderText = "";
            this.txtMKmoi.SelectedText = "";
            this.txtMKmoi.Size = new System.Drawing.Size(550, 42);
            this.txtMKmoi.TabIndex = 36;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Animated = true;
            this.txtXacNhanMK.BorderColor = System.Drawing.Color.Black;
            this.txtXacNhanMK.BorderRadius = 10;
            this.txtXacNhanMK.BorderThickness = 2;
            this.txtXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMK.DefaultText = "";
            this.txtXacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtXacNhanMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMK.Location = new System.Drawing.Point(318, 513);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PlaceholderText = "";
            this.txtXacNhanMK.SelectedText = "";
            this.txtXacNhanMK.Size = new System.Drawing.Size(550, 42);
            this.txtXacNhanMK.TabIndex = 37;
            // 
            // txtTen
            // 
            this.txtTen.Animated = true;
            this.txtTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTen.BorderColor = System.Drawing.Color.Black;
            this.txtTen.BorderRadius = 10;
            this.txtTen.BorderThickness = 2;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FillColor = System.Drawing.Color.LightGray;
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(318, 205);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "";
            this.txtTen.ReadOnly = true;
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(704, 42);
            this.txtTen.TabIndex = 38;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Animated = true;
            this.txtMaNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaNV.BorderColor = System.Drawing.Color.Black;
            this.txtMaNV.BorderRadius = 10;
            this.txtMaNV.BorderThickness = 2;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FillColor = System.Drawing.Color.LightGray;
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(318, 102);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(704, 42);
            this.txtMaNV.TabIndex = 39;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1071, 727);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.chkHienThi3);
            this.Controls.Add(this.chkHienThi2);
            this.Controls.Add(this.chkHienThi1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "frmDoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnDoiMatKhau;
        private Guna.UI2.WinForms.Guna2GradientButton btnThoat;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienThi1;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienThi2;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienThi3;
        private Guna.UI2.WinForms.Guna2TextBox txtMKcu;
        private Guna.UI2.WinForms.Guna2TextBox txtMKmoi;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
    }
}