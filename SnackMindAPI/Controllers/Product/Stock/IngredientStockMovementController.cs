using SnackMindAPI.Models;
using SnackMindModel.Product.Stock;
using SnackMindService.Service.ServiceBase.Product.Stock;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Stock
{
    [RoutePrefix("api/ingredientstockmovements")]
    public class IngredientStockMovementController : ApiController
    {
        private readonly IIngredientStockMovementService _ingredientStockMovementService;
        public IngredientStockMovementController(IIngredientStockMovementService ingredientStockMovementService)
        {
            _ingredientStockMovementService = ingredientStockMovementService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var movements = await _ingredientStockMovementService.GetAllAsync();
            if (movements == null || movements.Count == 0)
                return Ok(new ApiResponse<object>(false, "No ingredient stock movements found", movements));
            return Ok(new ApiResponse<object>(true, "Ingredient stock movements listed successfully", movements));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var movement = await _ingredientStockMovementService.GetByRefAsync(@ref);
            if (movement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock movement not found"));
            return Ok(new ApiResponse<mdlIngredientStockMovement>(true, "Ingredient stock movement found", movement));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlIngredientStockMovement movement)
        {
            if (movement == null)
                return BadRequest(new ApiResponse<object>(false, "Ingredient stock movement object is null").Message);
            var result = await _ingredientStockMovementService.AddAsync(movement);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock movement added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlIngredientStockMovement movement)
        {
            if (movement == null || @ref != movement.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid ingredient stock movement data").Message);
            var existingMovement = await _ingredientStockMovementService.GetByRefAsync(@ref);
            if (existingMovement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock movement not found"));
            var result = await _ingredientStockMovementService.UpdateAsync(movement);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock movement updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingMovement = await _ingredientStockMovementService.GetByRefAsync(@ref);
            if (existingMovement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock movement not found"));
            var result = await _ingredientStockMovementService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock movement deleted successfully"));
            return InternalServerError();
        }
    }
}