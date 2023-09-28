using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class BinhLuan
    {
        public int MaBinhLuan { get; set; }
        public int? MaKhachHang { get; set; }
        public int? MaSanPham { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? NgayGio { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
