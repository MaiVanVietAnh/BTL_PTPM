using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class ChiTietHoaDonNhap
    {
        public int MaChiTietHoaDonNhap { get; set; }
        public int? MaHoaDonNhap { get; set; }
        public int? MaSanPham { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual HoaDonNhap? MaHoaDonNhapNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
