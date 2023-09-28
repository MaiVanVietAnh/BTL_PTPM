using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            BinhLuans = new HashSet<BinhLuan>();
            DonHangs = new HashSet<DonHang>();
            HoaDonBans = new HashSet<HoaDonBan>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int MaKhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
