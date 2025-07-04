﻿using System;
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
                string maLoai = cboLoaiSP.SelectedValue.ToString(); // Nếu lấy MaLoai là int, sửa kiểu cho đúng thực tế!
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1); // Lấy hết ngày chọn

                var result = from ctp in db.ChiTietPhieus
                             join sp in db.SanPhams on ctp.MaSanPham equals sp.MaSanPham
                             join lsp in db.LoaiSanPhams on sp.MaLoai equals lsp.MaLoai
                             join pbh in db.PhieuBanHangs on ctp.MaPhieu equals pbh.MaPhieu
                             where sp.MaLoai == maLoai
                                 && pbh.NgayTao >= tuNgay && pbh.NgayTao < denNgay
                             group new { ctp, sp, pbh } by new
                             {
                                 sp.MaSanPham,
                                 sp.TenSanPham,
                                 NgayBan = pbh.NgayTao.Date
                             } into grp
                             select new
                             {
                                 MaSanPham = grp.Key.MaSanPham,
                                 TenSanPham = grp.Key.TenSanPham,
                                 TongTien = grp.Sum(x => x.ctp.SoLuong * x.ctp.DonGia),
                                 SoLuongLy = grp.Sum(x => x.ctp.SoLuong),
                                 SoLuongPhieu = grp.Select(x => x.ctp.MaPhieu).Distinct().Count(),
                                 NgayLapPhieu = grp.Key.NgayBan,
                                 TrangThai = grp.All(x => x.pbh.TrangThai) ? "Đã thanh toán" : "Chưa thanh toán"
                             };

                var data = result.AsEnumerable()
                    .Select(x => new
                    {
                        x.MaSanPham,
                        x.TenSanPham,
                        TongTien = x.TongTien.ToString("N0"),
                        SoLuongLy = x.SoLuongLy,
                        SoLuongPhieu = x.SoLuongPhieu,
                        NgayLapPhieu = x.NgayLapPhieu.ToString("dd/MM/yyyy"),
                        x.TrangThai
                    })
                    .ToList();

                dgvThongKe.DataSource = null;
                dgvThongKe.DataSource = data;
            }
        }
    }
}
