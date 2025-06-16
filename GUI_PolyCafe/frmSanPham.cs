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
    public partial class frmSanPham : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        private string _hinhAnhPath = "";
        public frmSanPham()
        {
            InitializeComponent();

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = Image.FromFile(openFileDialog.FileName);
                _hinhAnhPath = openFileDialog.FileName;
            }
        }



        private void LoadSanPham()
        {
            var list = db.SanPhams
                .Select(sp => new
                {
                    sp.MaSanPham,
                    sp.TenSanPham,
                    sp.DonGia,
                    LoaiSP = sp.LoaiSanPham.TenLoai,
                    sp.HinhAnh,
                    MaLoai = sp.LoaiSanPham.MaLoai
                })
                .ToList();
            dgvDSSP.DataSource = list;
            dgvDSSP.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvDSSP.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvDSSP.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDSSP.Columns["LoaiSP"].HeaderText = "Loại sản phẩm";
            dgvDSSP.Columns["HinhAnh"].HeaderText = "Hình ảnh";
            dgvDSSP.Columns["MaLoai"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
        string.IsNullOrWhiteSpace(txtTenSP.Text) ||
        string.IsNullOrWhiteSpace(txtDonGia.Text) ||
        cboLoaiSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số và không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.SanPhams.Any(sp => sp.MaSanPham == txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SanPham sp = new SanPham
                {
                    MaSanPham = txtMaSP.Text.Trim(),
                    TenSanPham = txtTenSP.Text.Trim(),
                    DonGia = donGia,
                    MaLoai = cboLoaiSP.SelectedValue.ToString(),
                    HinhAnh = _hinhAnhPath,
                    TrangThai = true
                };
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                cboLoaiSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số và không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSanPham == txtMaSP.Text);
                if (sp != null)
                {
                    sp.TenSanPham = txtTenSP.Text.Trim();
                    sp.DonGia = donGia;
                    sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                    if (!string.IsNullOrEmpty(_hinhAnhPath))
                    {
                        sp.HinhAnh = _hinhAnhPath;
                    }
                    sp.TrangThai = rdoHoatDong.Checked;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSanPham == txtMaSP.Text);
                if (sp != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.SanPhams.DeleteOnSubmit(sp);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoi();
                        LoadSanPham();
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLoaiSanPham();
        }
        private void LoadLoaiSanPham()
        {
            var loaiSPList = db.LoaiSanPhams
                .Select(l => new
                {
                    l.MaLoai,
                    l.TenLoai
                })
                .ToList();
            cboLoaiSP.DataSource = loaiSPList;
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvDSSP.Rows[e.RowIndex];
                    txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                    txtMaSP.Enabled = false;
                    txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                    txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                    var maLoai = db.LoaiSanPhams.SingleOrDefault(l => l.TenLoai == row.Cells["LoaiSP"].Value.ToString())?.MaLoai;
                    if (maLoai != null)
                        cboLoaiSP.SelectedValue = maLoai;
                    if (row.Cells["HinhAnh"].Value != null && !string.IsNullOrEmpty(row.Cells["HinhAnh"].Value.ToString()))
                    {
                        string imagePath = row.Cells["HinhAnh"].Value.ToString();
                        try
                        {
                            picturebox.Image = Image.FromFile(imagePath);
                        }
                        catch
                        {
                            picturebox.Image = null;
                        }
                        _hinhAnhPath = imagePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            cboLoaiSP.SelectedIndex = -1;
            picturebox.Image = null;
            _hinhAnhPath = "";
            rdoHoatDong.Checked = true;
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }  
}
