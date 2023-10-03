using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BLL.Interfaces
{
    public interface ISanPhamBusiness
    {
        Task<bool> Create(SanPhamModel model);

        Task<bool> Update(SanPhamModel model);
        Task<bool> Delete(int id);
        Task<List<SanPhamModel>> GetAllProduct();
        Task<List<HomePageModel>> GetNewProduct(int Soluong);
        Task<List<SanPhamModel>> GetProductCategory(int id);
        Task<List<HomePageModel>> GetProductBanChay(int sl);
        Task<List<HomePageModel>> GetProductOder(int sl);
        Task<SanPhamModel> GetByIdProduct(int id);
        Task<List<ImageModel>> GetAllSlide();
        List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, int? MaSanPham, string TenSanPham, string TenLoai, string option, decimal? FromPrice, decimal? ToPrice);
    }
}
