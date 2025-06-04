using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmThongKe : Form
    {
        PolyCafeDataContext db = new PolyCafeDataContext();
        public frmThongKe()
        {
            InitializeComponent();
            ThongKeLoad();
            cboLoaiSP.DataSource = db.LoaiSanPhams.ToList();
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }


        private void ThongKeLoad()
        {
            if (cboLoaiSP.SelectedIndex == -1) return;

            string maLoai = cboLoaiSP.SelectedValue?.ToString();
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");

            // Chuỗi kết nối từ LINQ to SQL context
            string connStr = db.Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("PolyCafe", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThongKe.DataSource = dt;

                // Tùy chỉnh tên cột nếu cần
                if (dgvThongKe.Columns.Count > 0)
                {
                    dgvThongKe.Columns["MaSanPham"].HeaderText = "Mã SP";
                    dgvThongKe.Columns["TenSanPham"].HeaderText = "Tên SP";
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
            if (cboLoaiSP.SelectedIndex != -1)
            {
                string maLoai = cboLoaiSP.SelectedValue.ToString();

                var result = from sp in db.SanPhams
                             join lsp in db.LoaiSanPhams on sp.MaLoai equals lsp.MaLoai
                             join ctp in db.ChiTietPhieus on sp.MaSanPham equals ctp.MaSanPham
                             join pbh in db.PhieuBanHangs on ctp.MaPhieu equals pbh.MaPhieu
                             where sp.MaLoai == maLoai
                             select new
                             {
                                 MaSP = sp.MaSanPham,
                                 TenSP = sp.TenSanPham,
                                 TenLoai = lsp.TenLoai,
                                 SoLuong = ctp.SoLuong,
                                 DonGia = ctp.DonGia,
                                 ThanhTien = ctp.SoLuong * ctp.DonGia,
                                 NgayBan = pbh.NgayTao
                             };

                dgvThongKe.DataSource = result.ToList();
            }
        }
    }
}
