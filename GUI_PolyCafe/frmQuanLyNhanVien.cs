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
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
        string.IsNullOrWhiteSpace(txtHoTen.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
        string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaNV.Text.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được quá 10 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text.Length < 4)
            {
                MessageBox.Show("Mật khẩu phải từ 4 ký tự trở lên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.NhanViens.Any(nv => nv.MaNhanVien == txtMaNV.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.NhanViens.Any(nv => nv.Email == txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại!", "Trùng email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool vaiTro = rdoQuanLy.Checked;
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = txtMaNV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = txtMatKhau.Text,
                    VaiTro = vaiTro
                };
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                LoadNhanVien();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lamMoi()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMK.Text = "";
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
            LoadNhanVien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
            txtMaNV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // code nút sửa nhân viên cho danh sách
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.NhanViens.Any(nv => nv.Email == txtEmail.Text && nv.MaNhanVien != txtMaNV.Text))
            {
                MessageBox.Show("Email đã tồn tại!", "Trùng email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool vaiTro = rdoQuanLy.Checked;
                var maNV = txtMaNV.Text;
                var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                if (nv != null)
                {
                    nv.HoTen = txtHoTen.Text.Trim();
                    nv.Email = txtEmail.Text.Trim();
                    nv.MatKhau = txtMatKhau.Text;
                    nv.VaiTro = vaiTro;

                    db.SubmitChanges();
                    LoadNhanVien();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // code nút xóa nhân viên cho danh sách
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var maNV = txtMaNV.Text;
                var nv = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNV);
                if (nv != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.NhanViens.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        LoadNhanVien();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lamMoi();
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin nhân viên khi click vào dòng trong DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSNV.Rows.Count)
            {
                var row = dgvDSNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtMaNV.Enabled = false;
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtXacNhanMK.Text = row.Cells["MatKhau"].Value.ToString();
                if (row.Cells["VaiTro"].Value.ToString() == "Quản lý")
                    rdoQuanLy.Checked = true;
                else
                    rdoNhanVien.Checked = true;
            }
        }
    }
}

