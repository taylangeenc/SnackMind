using SnackMindAPI.Models;
using SnackMindModel.Product.Recipe.Ingredient;
using SnackMindService.Service.ServiceBase.Product.Recipe.Ingredient;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Recipe.Ingredient
{
    [RoutePrefix("api/ingredients")]
    public class IngredientController : ApiController
    {
        private readonly IIngredientService _ingredientService;
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var ingredients = await _ingredientService.GetAllAsync();
            if (ingredients == null || ingredients.Count == 0)
                return Ok(new ApiResponse<object>(false, "No ingredients found", ingredients));
            return Ok(new ApiResponse<object>(true, "Ingredients listed successfully", ingredients));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var ingredient = await _ingredientService.GetByRefAsync(@ref);
            if (ingredient == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient not found"));
            return Ok(new ApiResponse<mdlIngredient>(true, "Ingredient found", ingredient));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlIngredient ingredient)
        {
            if (ingredient == null)
                return BadRequest(new ApiResponse<object>(false, "Ingredient object is null").Message);
            var result = await _ingredientService.AddAsync(ingredient);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlIngredient ingredient)
        {
            if (ingredient == null || @ref != ingredient.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid ingredient data").Message);
            var existingIngredient = await _ingredientService.GetByRefAsync(@ref);
            if (existingIngredient == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient not found"));
            var result = await _ingredientService.UpdateAsync(ingredient);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingIngredient = await _ingredientService.GetByRefAsync(@ref);
            if (existingIngredient == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient not found"));
            var result = await _ingredientService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient deleted successfully"));
            return InternalServerError();
        }
    }
}