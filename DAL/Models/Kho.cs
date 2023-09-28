using System;
using System.Collections.Generic;

namespace BTL_MaiVanVietAnh_12521155.Models
{
    public partial class Kho
    {
        public Kho()
        {
            ChiTietKhos = new HashSet<ChiTietKho>();
        }

        public int MaKho { get; set; }
        public string? TenKho { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<ChiTietKho> ChiTietKhos { get; set; }
    }
}
