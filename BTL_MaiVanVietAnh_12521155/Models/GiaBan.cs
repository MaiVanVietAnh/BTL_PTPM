using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class GiaBan
    {
        public int MaGiaSanPham { get; set; }
        public int? MaSanPham { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public double? Gia { get; set; }

        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
