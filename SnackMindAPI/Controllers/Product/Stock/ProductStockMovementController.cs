using SnackMindAPI.Models;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Stock
{
    [RoutePrefix("api/productstockmovements")]
    public class ProductStockMovementController : ApiController
    {
        private readonly IProductStockMovementService _productStockMovementService;
        public ProductStockMovementController(IProductStockMovementService productStockMovementService)
        {
            _productStockMovementService = productStockMovementService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var movements = await _productStockMovementService.GetAllAsync();
            if (movements == null || movements.Count == 0)
                return Ok(new ApiResponse<object>(false, "No product stock movements found", movements));
            return Ok(new ApiResponse<object>(true, "Product stock movements listed successfully", movements));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var movement = await _productStockMovementService.GetByRefAsync(@ref);
            if (movement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock movement not found"));
            return Ok(new ApiResponse<mdlProductStockMovement>(true, "Product stock movement found", movement));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlProductStockMovement movement)
        {
            if (movement == null)
                return BadRequest(new ApiResponse<object>(false, "Product stock movement object is null").Message);
            var result = await _productStockMovementService.AddAsync(movement);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock movement added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlProductStockMovement movement)
        {
            if (movement == null || @ref != movement.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid product stock movement data").Message);
            var existingMovement = await _productStockMovementService.GetByRefAsync(@ref);
            if (existingMovement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock movement not found"));
            var result = await _productStockMovementService.UpdateAsync(movement);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock movement updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingMovement = await _productStockMovementService.GetByRefAsync(@ref);
            if (existingMovement == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Product stock movement not found"));
            var result = await _productStockMovementService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Product stock movement deleted successfully"));
            return InternalServerError();
        }
    }
}