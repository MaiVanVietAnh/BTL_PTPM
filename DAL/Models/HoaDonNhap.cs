using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
        }

        public int MaHoaDonNhap { get; set; }
        public int? MaNhaCungCap { get; set; }
        public DateTime? NgayNhap { get; set; }
        public double? ThanhTien { get; set; }

        public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}
