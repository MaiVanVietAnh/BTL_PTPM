using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class ChiTietDonHang
    {
        public int MaChiTietDonHang { get; set; }
        public int? MaDonHang { get; set; }
        public int? MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public double? GiaBan { get; set; }

        public virtual DonHang? MaDonHangNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
