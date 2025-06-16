using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class ThongKeNV : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public ThongKeNV()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadTenNhanVien();
        }

        private void LoadTenNhanVien()
        {
            cboNV.DataSource = db.NhanViens.ToList();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNhanVien";
        }

        private void LoadNhanVien()
        {
            if (cboNV.SelectedIndex == -1) return;

            string tenNV = cboNV.SelectedValue?.ToString();
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");

            // Chuỗi kết nối từ LINQ to SQL context
            string connStr = db.Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("PolyCafe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HoTen", tenNV);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThongKe.DataSource = dt;

                // Tùy chỉnh tên cột nếu cần
                if (dgvThongKe.Columns.Count > 0)
                {
                    dgvThongKe.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    dgvThongKe.Columns["HoTen"].HeaderText = "Tên NV";
                    dgvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền";
                    dgvThongKe.Columns["SoLy"].HeaderText = "Số Lượng Ly";
                    dgvThongKe.Columns["NgayBan"].HeaderText = "Ngày Bán";
                    dgvThongKe.Columns["SoLuongPhieu"].HeaderText = "Số Phiếu";
                    dgvThongKe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cboNV.SelectedIndex != -1)
            {
                string maNV = cboNV.SelectedValue.ToString();
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1); // Thêm 1 ngày để lấy hết ngày chọn

                var result = from pbh in db.PhieuBanHangs
                             join nv in db.NhanViens on pbh.MaNhanVien equals nv.MaNhanVien
                             join ctp in db.ChiTietPhieus on pbh.MaPhieu equals ctp.MaPhieu
                             where nv.MaNhanVien == maNV
                                   && pbh.NgayTao >= tuNgay && pbh.NgayTao < denNgay
                             group new { pbh, nv, ctp } by new
                             {
                                 nv.MaNhanVien,
                                 nv.HoTen,
                                 NgayBan = pbh.NgayTao.Date
                             } into grp
                             select new
                             {
                                 MaNhanVien = grp.Key.MaNhanVien,
                                 HoTen = grp.Key.HoTen,
                                 TongTien = grp.Sum(x => x.ctp.SoLuong * x.ctp.DonGia),
                                 SoLuongLy = grp.Sum(x => x.ctp.SoLuong),
                                 SoLuongPhieu = grp.Select(x => x.pbh.MaPhieu).Distinct().Count(),
                                 NgayLapPhieu = grp.Key.NgayBan,
                                 TrangThai = grp.All(x => x.pbh.TrangThai) ? "Đã thanh toán" : "Chưa thanh toán"
                             };

                // Định dạng ngày, số tiền (nếu muốn)
                var data = result.AsEnumerable()
                    .Select(x => new
                    {
                        x.MaNhanVien,
                        x.HoTen,
                        TongTien = x.TongTien.ToString("N0"),
                        SoLuongLy = x.SoLuongLy,
                        SoLuongPhieu = x.SoLuongPhieu,
                        NgayLapPhieu = x.NgayLapPhieu.ToString("dd/MM/yyyy"),
                        x.TrangThai
                    })
                    .ToList();

                dgvThongKe.DataSource = null; // Reset trước khi gán lại
                dgvThongKe.DataSource = data;
            }
        }
    }
}
