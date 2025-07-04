using SnackMindAPI.Models;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Stock
{
    [RoutePrefix("api/productstocks")]
    public class ProductStockController : ApiController
    {
        private readonly IProductStockService _productStockService;
        public ProductStockController(IProductStockService productStockService)
        {
            _productStockService = productStockService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var stocks = await _productStockService.GetAllAsync();
            if (stocks == null || stocks.Count == 0)
                return Ok(new ApiResponse<object>(false, "No product stocks found", stocks));
            return Ok(new ApiResponse<object>(true, "Product stocks listed successfully", stocks));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var stock = await _productStockService.GetByRefAsync(@ref);
            if (stock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock not found"));
            return Ok(new ApiResponse<mdlProductStock>(true, "Product stock found", stock));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlProductStock stock)
        {
            if (stock == null)
                return BadRequest(new ApiResponse<object>(false, "Product stock object is null").Message);
            var result = await _productStockService.AddAsync(stock);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlProductStock stock)
        {
            if (stock == null || @ref != stock.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid product stock data").Message);
            var existingStock = await _productStockService.GetByRefAsync(@ref);
            if (existingStock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock not found"));
            var result = await _productStockService.UpdateAsync(stock);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingStock = await _productStockService.GetByRefAsync(@ref);
            if (existingStock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock not found"));
            var result = await _productStockService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock deleted successfully"));
            return InternalServerError();
        }
    }
}