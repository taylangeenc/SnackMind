using SnackMindAPI.Models;

using SnackMindModel.Product.Recipe.Recipe;

using SnackMindService.Service.ServiceBase.Product.Recipe.Recipe;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Recipe.Recipe
{
    [RoutePrefix("api/recipeitems")]
    public class RecipeItemController : ApiController
    {
        private readonly IRecipeItemService _recipeItemService;
        public RecipeItemController(IRecipeItemService recipeItemService)
        {
            _recipeItemService = recipeItemService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var items = await _recipeItemService.GetAllAsync();
            if (items == null || items.Count == 0)
                return Ok(new ApiResponse<object>(false, "No recipe items found", items));
            return Ok(new ApiResponse<object>(true, "Recipe items listed successfully", items));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var item = await _recipeItemService.GetByRefAsync(@ref);
            if (item == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe item not found"));
            return Ok(new ApiResponse<mdlRecipeItem>(true, "Recipe item found", item));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlRecipeItem item)
        {
            if (item == null)
                return BadRequest(new ApiResponse<object>(false, "Recipe item object is null").Message);
            var result = await _recipeItemService.AddAsync(item);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe item added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlRecipeItem item)
        {
            if (item == null || @ref != item.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid recipe item data").Message);
            var existingItem = await _recipeItemService.GetByRefAsync(@ref);
            if (existingItem == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe item not found"));
            var result = await _recipeItemService.UpdateAsync(item);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe item updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingItem = await _recipeItemService.GetByRefAsync(@ref);
            if (existingItem == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe item not found"));
            var result = await _recipeItemService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe item deleted successfully"));
            return InternalServerError();
        }
    }
}