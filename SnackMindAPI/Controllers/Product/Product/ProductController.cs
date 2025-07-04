using SnackMindAPI.Models;

using SnackMindModel.Product.Product;

using SnackMindService.Service.ServiceBase.Product.Product;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Product
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            if (products == null || products.Count == 0)
                return Ok(new ApiResponse<object>(false, "No products found", products));
            return Ok(new ApiResponse<object>(true, "Products listed successfully", products));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var products = await _productService.GetAllAsync(x => x.IsActive);
            if (products == null || products.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active products found", products));
            return Ok(new ApiResponse<object>(true, "Active products listed successfully", products));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var products = await _productService.GetAllAsync(x => !x.IsActive);
            if (products == null || products.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive products found", products));
            return Ok(new ApiResponse<object>(true, "Passive products listed successfully", products));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var product = await _productService.GetByRefAsync(@ref);
            if (product == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product not found"));
            return Ok(new ApiResponse<mdlProduct>(true, "Product found", product));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlProduct product)
        {
            if (product == null)
                return BadRequest(new ApiResponse<object>(false, "Product object is null").Message);
            var result = await _productService.AddAsync(product);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlProduct product)
        {
            if (product == null || @ref != product.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid product data").Message);
            var existingProduct = await _productService.GetByRefAsync(@ref);
            if (existingProduct == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product not found"));
            var result = await _productService.UpdateAsync(product);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingProduct = await _productService.GetByRefAsync(@ref);
            if (existingProduct == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product not found"));
            var result = await _productService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product deleted successfully"));
            return InternalServerError();
        }
    }
}