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
            try
            {
                LoaiSanPham loaiSP = new LoaiSanPham
                {
                    MaLoai = txtMaLoai.Text,
                    TenLoai = txtTenLoai.Text,
                    GhiChu = txtGhiChu.Text
                };
                db.LoaiSanPhams.InsertOnSubmit(loaiSP);
                db.SubmitChanges();
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var maLoai = txtMaLoai.Text;
                var loaiSP = db.LoaiSanPhams.FirstOrDefault(l => l.MaLoai == maLoai);
                if (loaiSP != null)
                {
                    loaiSP.TenLoai = txtTenLoai.Text;
                    loaiSP.GhiChu = txtGhiChu.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiSanPham();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với mã: " + maLoai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var maLoai = txtMaLoai.Text;
                var loaiSP = db.LoaiSanPhams.FirstOrDefault(l => l.MaLoai == maLoai);
                if (loaiSP != null)
                {
                    db.LoaiSanPhams.DeleteOnSubmit(loaiSP);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    LoadLoaiSanPham();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm với mã: " + maLoai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSLoai.Rows.Count)
            {
                var row = dgvDSLoai.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value != null ? row.Cells["GhiChu"].Value.ToString() : "";
            }
        }
    }
}
