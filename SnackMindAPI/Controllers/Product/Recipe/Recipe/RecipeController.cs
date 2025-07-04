using SnackMindAPI.Models;

using SnackMindModel.Product.Recipe.Recipe;

using SnackMindService.Service.ServiceBase.Product.Recipe.Recipe;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Recipe.Recipe
{
    [RoutePrefix("api/recipes")]
    public class RecipeController : ApiController
    {
        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var recipes = await _recipeService.GetAllAsync();
            if (recipes == null || recipes.Count == 0)
                return Ok(new ApiResponse<object>(false, "No recipes found", recipes));
            return Ok(new ApiResponse<object>(true, "Recipes listed successfully", recipes));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var recipe = await _recipeService.GetByRefAsync(@ref);
            if (recipe == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe not found"));
            return Ok(new ApiResponse<mdlRecipe>(true, "Recipe found", recipe));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlRecipe recipe)
        {
            if (recipe == null)
                return BadRequest(new ApiResponse<object>(false, "Recipe object is null").Message);
            var result = await _recipeService.AddAsync(recipe);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlRecipe recipe)
        {
            if (recipe == null || @ref != recipe.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid recipe data").Message);
            var existingRecipe = await _recipeService.GetByRefAsync(@ref);
            if (existingRecipe == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe not found"));
            var result = await _recipeService.UpdateAsync(recipe);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingRecipe = await _recipeService.GetByRefAsync(@ref);
            if (existingRecipe == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Recipe not found"));
            var result = await _recipeService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Recipe deleted successfully"));
            return InternalServerError();
        }
    }
}