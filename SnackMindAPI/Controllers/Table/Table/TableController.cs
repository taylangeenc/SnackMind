using SnackMindAPI.Models;
using SnackMindModel.Table.Table;
using SnackMindService.Service.ServiceBase.Table.Table;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Table.Table
{
    [RoutePrefix("api/tables")]
    public class TableController : ApiController
    {
        private readonly ITableService _tableService;
        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var tables = await _tableService.GetAllAsync();
            if (tables == null || tables.Count == 0)
                return Ok(new ApiResponse<object>(false, "No tables found", tables));
            return Ok(new ApiResponse<object>(true, "Tables listed successfully", tables));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var table = await _tableService.GetByRefAsync(@ref);
            if (table == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table not found"));
            return Ok(new ApiResponse<mdlTable>(true, "Table found", table));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlTable table)
        {
            if (table == null)
                return BadRequest(new ApiResponse<object>(false, "Table object is null").Message);
            var result = await _tableService.AddAsync(table);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlTable table)
        {
            if (table == null || @ref != table.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid table data").Message);
            var existingTable = await _tableService.GetByRefAsync(@ref);
            if (existingTable == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table not found"));
            var result = await _tableService.UpdateAsync(table);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingTable = await _tableService.GetByRefAsync(@ref);
            if (existingTable == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Table not found"));
            var result = await _tableService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Table deleted successfully"));
            return InternalServerError();
        }
    }
}