using DAL.Helper;
using DAL.Helper.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamRepository
    {
        private readonly IDatabaseHelper _dbHelper;
        public SanPhamRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public async Task<bool> Create(SanPhamModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sanpham_create",
                "@MaLoai", model.loaiSanPham.MaLoai,
                "@TenSanPham", model.TenSanPham,
                "@Anh", model.Anh,
                "@SoLuong", model.SoLuong,
                "@MoTa", model.Mota);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Update(SanPhamModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sanpham_update",
                "@MaSanPham", model.MaSanPham,
                "@MaLoai", model.loaiSanPham.MaLoai,
                "@TenSanPham", model.TenSanPham,
                "@Anh", model.Anh,
                "@SoLuong", model.SoLuong,
                "@MoTa", model.Mota);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Delete(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_delete", "@MaSanPham", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<SanPhamModel>> GetAllProduct()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_getAll");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SanPhamModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<HomePageModel>> GetNewProduct(int Soluong)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_moinhat", "@Soluong", Soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<HomePageModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<HomePageModel>> GetProductBanChay(int sl)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_banchay", "@soluong", sl);
                if (!string.IsNullOrEmpty(msgError))

                    throw new Exception(msgError);
                return dt.ConvertTo<HomePageModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<HomePageModel>> GetProductOder(int sl)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_oder", "@Sl", sl);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<HomePageModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<SanPhamModel>> GetProductCategory(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_theoloai", "@MaLoai", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SanPhamModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<SanPhamModel> GetByIdProduct(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_get_by_id", "@MaSanPham", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SanPhamModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<ImageModel>> GetAllSlide()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "slide_getall");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ImageModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SanPhamModel> Search(int pageIndex, int pageSize, out long total, int? MaSanPham = null, string? TenSanPham = null, string? TenLoai = null, string? option = null, decimal? FromPrice = null, decimal? ToPrice = null)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sanpham_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@TenSanPham", TenSanPham,
                    "@MaSanPham", MaSanPham,
                    "@TenLoai", TenLoai,
                    "@option", option,
                    "@FromPrice", FromPrice,
                    "@ToPrice", ToPrice);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<SanPhamModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
