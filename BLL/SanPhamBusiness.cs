using BLL.Interfaces;
using DataModel;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBusiness:ISanPhamBusiness
    {
        private ILoaiSanPhamRepository _res;
        public LoaiSanPhamBusiness(ILoaiSanPhamRepository res)
        {
            _res = res;
        }

        public async Task<bool> Create(LoaiSanPhamModel model)
        {
            return await _res.Create(model);
        }

        public async Task<bool> Delete(int id)
        {
            return await _res.Delete(id);
        }

        public async Task<List<LoaiSanPhamModel>> GetAll()
        {
            return await _res.GetAll();
        }

        public async Task<LoaiSanPhamModel> GetById(int id)
        {
            return await _res.GetById(id);
        }

        public async Task<bool> Update(LoaiSanPhamModel model)
        {
            return await _res.Update(model);
        }
    }
}
