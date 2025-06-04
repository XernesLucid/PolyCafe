using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaLoai { get; set; }
        public string HinhAnh { get; set; }
        public float DonGia { get; set; }

        public SanPham(string maSanPham, string tenSanPham, string maLoai, string hinhAnh, float donGia)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.MaLoai = maLoai;
            this.HinhAnh = hinhAnh;
            this.DonGia = donGia;
        }
    }
}
