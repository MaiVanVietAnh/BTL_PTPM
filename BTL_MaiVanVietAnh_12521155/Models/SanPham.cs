using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            BinhLuans = new HashSet<BinhLuan>();
            ChiTietAnhSanPhams = new HashSet<ChiTietAnhSanPham>();
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
            ChiTietHoaDonNhaps = new HashSet<ChiTietHoaDonNhap>();
            ChiTietKhos = new HashSet<ChiTietKho>();
            GiaBans = new HashSet<GiaBan>();
        }

        public int MaSanPham { get; set; }
        public int? MaLoai { get; set; }
        public string TenSanPham { get; set; } = null!;
        public string? Anh { get; set; }
        public int? SoLuong { get; set; }
        public string? Mota { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual LoaiSanPham? MaLoaiNavigation { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<ChiTietAnhSanPham> ChiTietAnhSanPhams { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public virtual ICollection<ChiTietKho> ChiTietKhos { get; set; }
        public virtual ICollection<GiaBan> GiaBans { get; set; }
    }
}
