using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class TaiKhoan
    {
        public int MaTaiKhoan { get; set; }
        public string? TaiKhoan1 { get; set; }
        public string? MatKhau { get; set; }
        public int? MaKhachHang { get; set; }
        public bool? TrangThai { get; set; }
        public int? MaUserGroup { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual UserGroup? MaUserGroupNavigation { get; set; }
    }
}
