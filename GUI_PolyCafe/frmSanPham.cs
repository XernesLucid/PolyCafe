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
                    sp.HinhAnh
                })
                .ToList();
            dgvDSSP.DataSource = list;
            dgvDSSP.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvDSSP.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvDSSP.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDSSP.Columns["LoaiSP"].HeaderText = "Loại sản phẩm";
            dgvDSSP.Columns["HinhAnh"].HeaderText = "Hình ảnh";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham sp = new SanPham
                {
                    MaSanPham = txtMaSP.Text,
                    TenSanPham = txtTenSP.Text,
                    DonGia = decimal.Parse(txtDonGia.Text),
                    MaLoai = cboLoaiSP.SelectedValue.ToString(),
                    HinhAnh = _hinhAnhPath,
                    TrangThai = true
                };
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSanPham == txtMaSP.Text);
                if (sp != null)
                {
                    sp.TenSanPham = txtTenSP.Text;
                    sp.DonGia = decimal.Parse(txtDonGia.Text);
                    sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                    if (!string.IsNullOrEmpty(_hinhAnhPath))
                    {
                        sp.HinhAnh = _hinhAnhPath;
                    }
                    //xét lựa chọn trạng thái sản phẩm
                    sp.TrangThai = (rdoHoatDong.Checked || rdoNgungBan.Checked);
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật sản phẩm thành công!");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSanPham == txtMaSP.Text);
                if (sp != null)
                {
                    db.SanPhams.DeleteOnSubmit(sp);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
    }  
}
