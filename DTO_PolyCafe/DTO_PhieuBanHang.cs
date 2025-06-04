using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class PhieuBanHang
    {
        public string MaPhieu { get; set; }
        public string MaThe { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayTao { get; set; } = new DateTime();
        public bool TrangThai { get; set; } = true;

        public PhieuBanHang(string maPhieu, string maThe, string maNhanVien, DateTime ngayTao, bool trangThai)
        {
            this.MaPhieu = maPhieu;
            this.MaThe = maThe;
            this.MaNhanVien = maNhanVien;
            this.NgayTao = ngayTao;
            this.TrangThai = trangThai;
        }
    }
}
