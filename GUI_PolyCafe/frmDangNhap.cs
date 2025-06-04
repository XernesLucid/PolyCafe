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
    public partial class frmDangNhap : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void cbxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtMatKhau.PasswordChar = chkHienThi.Checked ? '\0' : '*';
            } 
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string matkhau = txtMatKhau.Text;

            // Ví dụ: đăng nhập bằng tên đăng nhập (TenDangNhap), thay bằng trường phù hợp nếu có
            var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == ten);

            if (nhanvien == null)
            {
                MessageBox.Show(this, "Tài khoản không tồn tại");
            }
            else if (nhanvien.MatKhau != matkhau)
            {
                MessageBox.Show(this, "Sai mật khẩu");
            }
            else
            {
                MessageBox.Show(this, "Đăng nhập thành công");
                Task.Delay(3000).ContinueWith(t =>
                {
                    Invoke(new Action(() =>
                    {
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        this.Close();

                    }));
                });
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; 
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void QuenMK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn quên mật khẩu?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDoiMatKhau frm = new frmDoiMatKhau();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
