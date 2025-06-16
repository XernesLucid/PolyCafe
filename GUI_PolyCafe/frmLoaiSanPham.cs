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
    public partial class frmLoaiSanPham : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã và tên loại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void LoadLoaiSanPham()
        {
            var list = db.LoaiSanPhams
                .Select(lsp => new
                {
                    lsp.MaLoai,
                    lsp.TenLoai,
                    lsp.GhiChu
                })
                .ToList();
            dgvDSLoai.DataSource = list;
            dgvDSLoai.Columns["MaLoai"].HeaderText = "Mã loại sản phẩm";
            dgvDSLoai.Columns["TenLoai"].HeaderText = "Tên loại sản phẩm";
            dgvDSLoai.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (db.LoaiSanPhams.Any(l => l.MaLoai == txtMaLoai.Text))
            {
                MessageBox.Show("Mã loại đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                db.LoaiSanPhams.InsertOnSubmit(new LoaiSanPham
                {
                    MaLoai = txtMaLoai.Text.Trim(),
                    TenLoai = txtTenLoai.Text.Trim(),
                    GhiChu = txtGhiChu.Text.Trim()
                });
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
            LoadLoaiSanPham();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            txtMaLoai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var loaiSP = db.LoaiSanPhams.FirstOrDefault(l => l.MaLoai == txtMaLoai.Text);
            if (loaiSP == null)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                loaiSP.TenLoai = txtTenLoai.Text.Trim();
                loaiSP.GhiChu = txtGhiChu.Text.Trim();
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại cần xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var loaiSP = db.LoaiSanPhams.FirstOrDefault(l => l.MaLoai == txtMaLoai.Text);
            if (loaiSP == null)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    db.LoaiSanPhams.DeleteOnSubmit(loaiSP);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDSLoai.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
                txtMaLoai.Enabled = false;
            }
        }
    }
}
