using SnackMindAPI.Models;

using SnackMindModel.Product.Category;

using SnackMindService.Service.ServiceBase.Product.Category;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Category
{
    [RoutePrefix("api/parentcategories")]
    public class ParentCategoryController : ApiController
    {
        private readonly IParentCategoryService _parentCategoryService;
        public ParentCategoryController(IParentCategoryService parentCategoryService)
        {
            _parentCategoryService = parentCategoryService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var categories = await _parentCategoryService.GetAllAsync();
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No parent categories found", categories));
            return Ok(new ApiResponse<object>(true, "Parent categories listed successfully", categories));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var categories = await _parentCategoryService.GetAllAsync(x => x.IsActive);
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active parent categories found", categories));
            return Ok(new ApiResponse<object>(true, "Active parent categories listed successfully", categories));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var categories = await _parentCategoryService.GetAllAsync(x => !x.IsActive);
            if (categories == null || categories.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive parent categories found", categories));
            return Ok(new ApiResponse<object>(true, "Passive parent categories listed successfully", categories));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var category = await _parentCategoryService.GetByRefAsync(@ref);
            if (category == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Parent category not found"));
            return Ok(new ApiResponse<mdlParentCategory>(true, "Parent category found", category));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlParentCategory category)
        {
            if (category == null)
                return BadRequest(new ApiResponse<object>(false, "Parent category object is null").Message);
            var result = await _parentCategoryService.AddAsync(category);
            if (result)
                return Ok(new ApiResponse<object>(true, "Parent category added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlParentCategory category)
        {
            if (category == null || @ref != category.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid parent category data").Message);
            var existingCategory = await _parentCategoryService.GetByRefAsync(@ref);
            if (existingCategory == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Parent category not found"));
            var result = await _parentCategoryService.UpdateAsync(category);
            if (result)
                return Ok(new ApiResponse<object>(true, "Parent category updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingCategory = await _parentCategoryService.GetByRefAsync(@ref);
            if (existingCategory == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Parent category not found"));
            var result = await _parentCategoryService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Parent category deleted successfully"));
            return InternalServerError();
        }
    }
}