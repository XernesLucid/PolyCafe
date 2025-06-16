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
    public partial class frmMain : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Task.Delay(3000).ContinueWith(t =>
                {
                    Invoke(new Action(() =>
                    {
                        this.Hide();
                        frmDangNhap frm = new frmDangNhap();
                        frm.ShowDialog();
                        this.Close();

                    }));
                });

            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau changePasswordForm = new frmDoiMatKhau();
            changePasswordForm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien employeeForm = new frmQuanLyNhanVien();
            employeeForm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSanPham productForm = new frmSanPham();
            productForm.ShowDialog();
        }

        private void loạiPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham productTypeForm = new frmLoaiSanPham();
            productTypeForm.ShowDialog();
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuBanHang salesReceiptForm = new frmPhieuBanHang();
            salesReceiptForm.ShowDialog();
        }


        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLuuDong cardForm = new frmTheLuuDong();
            cardForm.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
        }

        private void thốngKêTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeNV thongKeNV = new ThongKeNV();
            thongKeNV.ShowDialog();
        }
    }
}
