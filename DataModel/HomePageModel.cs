using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class HomePageModel
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string Anh { get; set; }
        public int SoLuong { get; set; }
        public string Mota { get; set; }
        public DateTime NgayTao { get; set; }

        public LoaiSanPhamModel loaiSanPham { get; set; }
        public int SoLuongDaBan { get; set; }
        public int SoLuongDatHang { get; set; }
    }
}
