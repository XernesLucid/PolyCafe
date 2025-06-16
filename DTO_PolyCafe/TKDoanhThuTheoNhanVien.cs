using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class TKDoanhThuTheoNhanVien
    {
        public String MaNhanVien {  get; set; }
        public String HoTen { get; set; }
        public Decimal TongTien { get; set; }
        public Int32 SoLy {  get; set; }
        public DateTime NgayBan { get; set; }
        public Int32 SoLuongPhieu { get; set; }
        public Boolean DaThanhToan { get; set; }
    }
}
