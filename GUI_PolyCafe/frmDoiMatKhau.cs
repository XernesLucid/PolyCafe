using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmDoiMatKhau : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string matKhauCu = txtMKcu.Text;
            string matKhauMoi = txtMKmoi.Text;
            string xacNhan = txtXacNhanMK.Text;

            // Kiểm tra nhập đủ thông tin
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(matKhauCu) ||
                string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận
            if (matKhauMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm nhân viên
            var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNV);
            if (nhanvien == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu cũ
            if (nhanvien.MatKhau != matKhauCu)
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật mật khẩu mới
            nhanvien.MatKhau = matKhauMoi;
            db.SubmitChanges(); // Lưu thay đổi vào SQL

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            if (!string.IsNullOrEmpty(maNV))
            {
                var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNV);
                if (nhanvien != null)
                {
                    txtTen.Text = nhanvien.HoTen;
                }
                else
                {
                    txtTen.Text = "";
                }
            }
            else
            {
                txtTen.Text = "";
            }

            // Ẩn mật khẩu mặc định
            txtMKcu.PasswordChar = '*';
            txtMKmoi.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';
        }

        private void chkHienThi1_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtMKcu.PasswordChar = chkHienThi1.Checked ? '\0' : '*';
            }
        }

        private void chkHienThi2_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtMKmoi.PasswordChar = chkHienThi2.Checked ? '\0' : '*';
            }
        }

        private void chkHienThi3_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtXacNhanMK.PasswordChar = chkHienThi3.Checked ? '\0' : '*';
            }
        }

        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {

        }
    }
}
