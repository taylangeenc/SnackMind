using SnackMindAPI.Models;
using SnackMindModel.Place.Warehouse;
using SnackMindService.Service.ServiceBase.Place.Warehouse;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Place.Warehouse
{
    [RoutePrefix("api/warehouses")]
    public class WarehouseController : ApiController
    {
        private readonly IWarehouseService _warehouseService;
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var warehouses = await _warehouseService.GetAllAsync();
            if (warehouses == null || warehouses.Count == 0)
                return Ok(new ApiResponse<object>(false, "No warehouses found", warehouses));
            return Ok(new ApiResponse<object>(true, "Warehouses listed successfully", warehouses));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var warehouses = await _warehouseService.GetAllAsync(x => x.IsActive);
            if (warehouses == null || warehouses.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active warehouses found", warehouses));
            return Ok(new ApiResponse<object>(true, "Active warehouses listed successfully", warehouses));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var warehouses = await _warehouseService.GetAllAsync(x => !x.IsActive);
            if (warehouses == null || warehouses.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive warehouses found", warehouses));
            return Ok(new ApiResponse<object>(true, "Passive warehouses listed successfully", warehouses));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var warehouse = await _warehouseService.GetByRefAsync(@ref);
            if (warehouse == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Warehouse not found"));
            return Ok(new ApiResponse<mdlWarehouse>(true, "Warehouse found", warehouse));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlWarehouse warehouse)
        {
            if (warehouse == null)
                return BadRequest(new ApiResponse<object>(false, "Warehouse object is null").Message);
            var result = await _warehouseService.AddAsync(warehouse);
            if (result)
                return Ok(new ApiResponse<object>(true, "Warehouse added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlWarehouse warehouse)
        {
            if (warehouse == null || @ref != warehouse.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid warehouse data").Message);
            var existingWarehouse = await _warehouseService.GetByRefAsync(@ref);
            if (existingWarehouse == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Warehouse not found"));
            var result = await _warehouseService.UpdateAsync(warehouse);
            if (result)
                return Ok(new ApiResponse<object>(true, "Warehouse updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingWarehouse = await _warehouseService.GetByRefAsync(@ref);
            if (existingWarehouse == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Warehouse not found"));
            var result = await _warehouseService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Warehouse deleted successfully"));
            return InternalServerError();
        }
    }
}