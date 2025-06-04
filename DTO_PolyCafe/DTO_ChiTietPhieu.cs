using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class ChiTietPhieu
    {
        public string MaPhieu { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }

        public ChiTietPhieu(string maPhieu, string maSanPham, int soLuong, float donGia, float thanhTien)
        {
            this.MaPhieu = maPhieu;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
    }
}
