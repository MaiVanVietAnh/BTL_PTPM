using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DAL.Interfaces
{
    public partial interface IKhachHangRepository
    {
        KhachHangModel getDatabyID(string id);

        bool Create(KhachHangModel data);
        bool Update(KhachHangModel data);

        public List<KhachHangModel> Search(int pageIndex, int pageSize, out long total, string ten_Khach, string dia_chi);
    }
}
