using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class ChiTietKho
    {
        public int MaChiTietKho { get; set; }
        public int? MaSanPham { get; set; }
        public int? MaKho { get; set; }
        public int? SoLuong { get; set; }

        public virtual Kho? MaKhoNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
