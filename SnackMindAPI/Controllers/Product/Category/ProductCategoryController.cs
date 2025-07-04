using SnackMindAPI.Models;
using SnackMindModel.Product.Category;
using SnackMindService.Service.ServiceBase.Product.Category;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Category
{
    [RoutePrefix("api/productcategories")]
    public class ProductCategoryController : ApiController
    {
        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var categories = await _productCategoryService.GetAllAsync();
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No product categories found", categories));
            return Ok(new ApiResponse<object>(true, "Product categories listed successfully", categories));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var categories = await _productCategoryService.GetAllAsync(x => x.IsActive);
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active product categories found", categories));
            return Ok(new ApiResponse<object>(true, "Active product categories listed successfully", categories));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var categories = await _productCategoryService.GetAllAsync(x => !x.IsActive);
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive product categories found", categories));
            return Ok(new ApiResponse<object>(true, "Passive product categories listed successfully", categories));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var category = await _productCategoryService.GetByRefAsync(@ref);
            if (category == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product category not found"));
            return Ok(new ApiResponse<mdlProductCategory>(true, "Product category found", category));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlProductCategory category)
        {
            if (category == null)
                return BadRequest(new ApiResponse<object>(false, "Product category object is null").Message);
            var result = await _productCategoryService.AddAsync(category);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product category added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlProductCategory category)
        {
            if (category == null || @ref != category.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid product category data").Message);
            var existingCategory = await _productCategoryService.GetByRefAsync(@ref);
            if (existingCategory == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product category not found"));
            var result = await _productCategoryService.UpdateAsync(category);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product category updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingCategory = await _productCategoryService.GetByRefAsync(@ref);
            if (existingCategory == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product category not found"));
            var result = await _productCategoryService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product category deleted successfully"));
            return InternalServerError();
        }
    }
}