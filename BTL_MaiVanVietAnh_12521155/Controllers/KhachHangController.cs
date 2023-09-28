using BLL.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace BTL_MaiVanVietAnh_12521155.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KhachHangController : ControllerBase
    
    {
        private IKhachHangBusiness _khachhangBusiness;
        public KhachHangController(IKhachHangBusiness khachhangBusiness)
        {
            _khachhangBusiness = khachhangBusiness;
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public KhachHangModel GetDatabyID(string id)
        {
            return _khachhangBusiness.GetDatabyID(id);
        }
        [Route("create-khach")]
        [HttpPost]
        public KhachHangModel CreateItem([FromBody] KhachHangModel model)
        {
            _khachhangBusiness.Create(model);
            return model;
        }
        [Route("update-khach")]
        [HttpPost]
        public KhachHangModel UpdateItem([FromBody] KhachHangModel model)
        {
            _khachhangBusiness.Update(model);
            return model;
        }
        [Route("search")]
        [HttpPost]
        public IActionResult Search([FromBody] Dictionary<string, object> formData)
        {
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string ten_khach = "";
                if (formData.Keys.Contains("ten_khach") && !string.IsNullOrEmpty(Convert.ToString(formData["ten_khach"]))) { ten_khach = Convert.ToString(formData["ten_khach"]); }
                string dia_chi = "";
                if (formData.Keys.Contains("dia_chi") && !string.IsNullOrEmpty(Convert.ToString(formData["dia_chi"]))) { dia_chi = Convert.ToString(formData["dia_chi"]); }
                long total = 0;
                var data = _khachhangBusiness.Search(page, pageSize, out total, ten_khach, dia_chi);
                return Ok(
                    new
                    {
                        TotalItems = total,
                        Data = data,
                        Page = page,
                        PageSize = pageSize
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}