using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class ChiTietAnhSanPham
    {
        public int MaChiTietAnhSanPham { get; set; }
        public int? MaSanPham { get; set; }

        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
