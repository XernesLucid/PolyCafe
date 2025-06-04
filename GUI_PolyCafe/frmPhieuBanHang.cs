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
    public partial class frmPhieuBanHang : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmPhieuBanHang()
        {
            InitializeComponent();
            LoadPhieuBanHang();
            LoadComboBox();
            LoadChiTietPhieu();
        }

        private void LoadComboBox()
        {
            // Load nhân viên
            cboNhanVien.DataSource = db.NhanViens.ToList();
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";

            // Load thẻ
            cboThe.DataSource = db.TheLuuDongs.ToList();
            cboThe.DisplayMember = "MaThe";
            cboThe.ValueMember = "MaThe";

            // Load sản phẩm cho chi tiết phiếu
            cboSanPham.DataSource = db.SanPhams.ToList();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "MaSanPham";
        }

        private void LoadPhieuBanHang()
        {
            var list = db.PhieuBanHangs.Select(p => new
            {
                p.MaPhieu,
                p.MaThe,
                p.MaNhanVien,
                p.NgayTao,
                p.TrangThai
            }).ToList();
            dgvPhieuBanHang.DataSource = list;
        }

            private void LoadChiTietPhieu()
        {
            var list = db.ChiTietPhieus.Select(p => new
            {
                p.Id,
                p.MaPhieu,
                p.MaSanPham,
                p.SoLuong,
                p.DonGia,
                ThanhTien = p.SoLuong * p.DonGia
            }).ToList();
            dgvPhieuChiTiet.DataSource = list;
        }


        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuBanHang phieu = new PhieuBanHang
                {
                    MaPhieu = txtMaPhieu.Text,
                    MaThe = cboThe.SelectedValue.ToString(),
                    MaNhanVien = cboNhanVien.SelectedValue.ToString(),
                    NgayTao = dtpNgayTao.Value,
                    TrangThai = rdoChoXacNhan.Checked ? false : true
                };
                db.PhieuBanHangs.InsertOnSubmit(phieu);
                db.SubmitChanges();
                MessageBox.Show("Thêm phiếu thành công!");
                LoadPhieuBanHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = db.PhieuBanHangs.SingleOrDefault(p => p.MaPhieu == txtMaPhieu.Text);
                if (phieu != null)
                {
                    phieu.MaThe = cboThe.SelectedValue.ToString();
                    phieu.MaNhanVien = cboNhanVien.SelectedValue.ToString();
                    phieu.NgayTao = dtpNgayTao.Value;
                    phieu.TrangThai = rdoChoXacNhan.Checked ? false : true;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa phiếu thành công!");
                    LoadPhieuBanHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LamMoi()
        {
            txtMaPhieu.Text = "";
            cboThe.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            rdoChoXacNhan.Checked = true;
            rdoDaThanhToan.Checked = false;
        }
        private void btnLamMoiPhieu_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = db.PhieuBanHangs.SingleOrDefault(p => p.MaPhieu == txtMaPhieu.Text);
                if (phieu != null)
                {
                    db.PhieuBanHangs.DeleteOnSubmit(phieu);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa phiếu thành công!");
                    LoadPhieuBanHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần thanh toán!");
                return;
            }

            var phieu = db.PhieuBanHangs.SingleOrDefault(p => p.MaPhieu == txtMaPhieu.Text);
            if (phieu == null)
            {
                MessageBox.Show("Không tìm thấy phiếu bán hàng!");
                return;
            }

            if (phieu.TrangThai == true)
            {
                MessageBox.Show("Phiếu này đã được thanh toán!");
                return;
            }

            phieu.TrangThai = true;
            db.SubmitChanges();
            MessageBox.Show("Thanh toán thành công!");
            LoadPhieuBanHang();

            // Cập nhật lại trạng thái trên form
            rdoDaThanhToan.Checked = true;
            rdoChoXacNhan.Checked = false;
        }





        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietPhieu ctp = new ChiTietPhieu
                {
                    MaPhieu = txtMaPhieu.Text,
                    MaSanPham = cboSanPham.SelectedValue.ToString(),
                    DonGia = decimal.Parse(txtDonGia.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                };
                db.ChiTietPhieus.InsertOnSubmit(ctp);
                db.SubmitChanges();
                MessageBox.Show("Thêm chi tiết phiếu thành công!");
                LoadChiTietPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                var ctp = db.ChiTietPhieus.SingleOrDefault(
                    x => x.MaPhieu == txtMaPhieu.Text && x.MaSanPham == cboSanPham.SelectedValue.ToString());
                if (ctp != null)
                {
                    ctp.DonGia = decimal.Parse(txtDonGia.Text);
                    ctp.SoLuong = int.Parse(txtSoLuong.Text);
                    db.SubmitChanges();
                    MessageBox.Show("Sửa chi tiết phiếu thành công!");
                    LoadChiTietPhieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                var ctp = db.ChiTietPhieus.SingleOrDefault(
                    x => x.MaPhieu == txtMaPhieu.Text && x.MaSanPham == cboSanPham.SelectedValue.ToString());
                if (ctp != null)
                {
                    db.ChiTietPhieus.DeleteOnSubmit(ctp);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa chi tiết phiếu thành công!");
                    LoadChiTietPhieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvPhieuChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPhieuChiTiet.Rows[e.RowIndex];

                // Lấy mã sản phẩm từ dòng được chọn
                string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                cboSanPham.SelectedValue = maSanPham;

                // Lấy đơn giá và số lượng
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                // Tính thành tiền (nếu có cột này)
                if (row.Cells["ThanhTien"] != null && row.Cells["ThanhTien"].Value != null)
                {
                    txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                }
                else
                {
                    // Nếu không có cột thành tiền, tự tính
                    decimal donGia = decimal.Parse(txtDonGia.Text);
                    int soLuong = int.Parse(txtSoLuong.Text);
                    txtThanhTien.Text = (donGia * soLuong).ToString();
                }
            }
        }

        private void dgvPhieuBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    var row = dgvPhieuBanHang.Rows[e.RowIndex];

                    // Hiển thị thông tin phiếu lên các control
                    txtMaPhieu.Text = row.Cells["MaPhieu"].Value?.ToString();
                    cboThe.SelectedValue = row.Cells["MaThe"].Value?.ToString();
                    cboNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value?.ToString();

                    // Ngày tạo
                    if (row.Cells["NgayTao"].Value != null)
                    {
                        DateTime ngayTao;
                        if (DateTime.TryParse(row.Cells["NgayTao"].Value.ToString(), out ngayTao))
                        {
                            dtpNgayTao.Value = ngayTao;
                        }
                    }

                    // Trạng thái
                    if (row.Cells["TrangThai"].Value != null)
                    {
                        bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                        rdoChoXacNhan.Checked = !trangThai;
                        rdoDaThanhToan.Checked = trangThai;
                    }

                    // Load chi tiết phiếu tương ứng
                    LoadPhieuBanHang();
                }
            }
        }
    }
}
