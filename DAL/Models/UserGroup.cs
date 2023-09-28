using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int MaUserGroup { get; set; }
        public string? TenQuyen { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
