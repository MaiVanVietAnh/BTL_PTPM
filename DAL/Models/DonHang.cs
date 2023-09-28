using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public int MaDonHang { get; set; }
        public int? MaKhachHang { get; set; }
        public DateTime? NgayDat { get; set; }
        public bool? TrangThai { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
