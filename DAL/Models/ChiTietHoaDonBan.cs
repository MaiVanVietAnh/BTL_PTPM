using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class ChiTietHoaDonBan
    {
        public int MaChiTietHoaDonBan { get; set; }
        public int? MaHoaDonBan { get; set; }
        public int? MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public double? GiaBan { get; set; }

        public virtual HoaDonBan? MaHoaDonBanNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
