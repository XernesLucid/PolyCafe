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
    public partial class frmQuanLyNhanVien : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void LoadNhanVien()
        {
            // Lấy danh sách nhân viên từ database
            var list = db.NhanViens
                .Select(nv => new
                {
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.Email,
                    nv.MatKhau,
                    VaiTro = nv.VaiTro ? "Quản lý" : "Nhân viên"
                })
                .ToList();

            dgvDSNV.DataSource = list;

            dgvDSNV.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvDSNV.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvDSNV.Columns["Email"].HeaderText = "Email";
            dgvDSNV.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvDSNV.Columns["MatKhau"].Visible = false;
            dgvDSNV.Columns["VaiTro"].HeaderText = "Vai trò";
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // code nút thêm nhân viên cho danh sách
            try
            {
                // VaiTro: true = Quản lý, false = Nhân viên
                bool vaiTro = rdoQuanLy.Checked;

                NhanVien nv = new NhanVien
                {
                    MaNhanVien = txtMaNV.Text,
                    HoTen = txtHoTen.Text,
                    Email = txtEmail.Text,
                    MatKhau = txtMatKhau.Text,
                    VaiTro = vaiTro
                };

                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                LoadNhanVien();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }
        private void lamMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMK.Text = "";
            txtMaNV.Focus();
            LoadNhanVien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // code nút sửa nhân viên cho danh sách
            try
            {
                bool vaiTro = rdoQuanLy.Checked;
                var maNV = txtMaNV.Text;

                var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                if (nv != null)
                {
                    nv.HoTen = txtHoTen.Text;
                    nv.Email = txtEmail.Text;
                    nv.MatKhau = txtMatKhau.Text;
                    nv.VaiTro = vaiTro;

                    db.SubmitChanges();
                    LoadNhanVien();
                    MessageBox.Show("Sửa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // code nút xóa nhân viên cho danh sách
            try
            {
                var maNV = txtMaNV.Text;
                var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                if (nv != null)
                {
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    LoadNhanVien();
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin nhân viên khi click vào dòng trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSNV.Rows.Count)
            {
                var row = dgvDSNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                // Cập nhật radio button cho vai trò
                if (row.Cells["VaiTro"].Value.ToString() == "Quản lý")
                {
                    rdoQuanLy.Checked = true;
                }
                else
                {
                    rdoNhanVien.Checked = true;
                }
            }
        }
    }
}

