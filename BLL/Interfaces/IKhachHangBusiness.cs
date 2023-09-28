using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;


namespace BLL.Interfaces
{
    public partial interface IKhachHangBusiness
    {
        KhachHangModel GetDatabyID(string id);
        bool Create(KhachHangModel model);
        bool Update(KhachHangModel model);
        public List<KhachHangModel> Search(int pageIndex, int pageSize, out long total, string ten_khach, string dia_chi);
    }
}
