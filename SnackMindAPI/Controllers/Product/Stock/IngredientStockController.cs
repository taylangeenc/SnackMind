using SnackMindAPI.Models;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Stock
{
    [RoutePrefix("api/ingredientstocks")]
    public class IngredientStockController : ApiController
    {
        private readonly IIngredientStockService _ingredientStockService;
        public IngredientStockController(IIngredientStockService ingredientStockService)
        {
            _ingredientStockService = ingredientStockService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var stocks = await _ingredientStockService.GetAllAsync();
            if (stocks == null || stocks.Count == 0)
                return Ok(new ApiResponse<object>(false, "No ingredient stocks found", stocks));
            return Ok(new ApiResponse<object>(true, "Ingredient stocks listed successfully", stocks));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var stock = await _ingredientStockService.GetByRefAsync(@ref);
            if (stock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock not found"));
            return Ok(new ApiResponse<mdlIngredientStock>(true, "Ingredient stock found", stock));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlIngredientStock stock)
        {
            if (stock == null)
                return BadRequest(new ApiResponse<object>(false, "Ingredient stock object is null").Message);
            var result = await _ingredientStockService.AddAsync(stock);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlIngredientStock stock)
        {
            if (stock == null || @ref != stock.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid ingredient stock data").Message);
            var existingStock = await _ingredientStockService.GetByRefAsync(@ref);
            if (existingStock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock not found"));
            var result = await _ingredientStockService.UpdateAsync(stock);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingStock = await _ingredientStockService.GetByRefAsync(@ref);
            if (existingStock == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Ingredient stock not found"));
            var result = await _ingredientStockService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Ingredient stock deleted successfully"));
            return InternalServerError();
        }
    }
}