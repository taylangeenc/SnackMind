using SnackMindAPI.Models;

using SnackMindModel.Place.Zone;

using SnackMindService.Service.ServiceBase.Place.Zone;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Place.Zone
{
    public class ZoneController : ApiController
    {
        private readonly IZoneService _zoneService;
        public ZoneController(IZoneService zoneService)
        {
            _zoneService = zoneService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var tables = await _zoneService.GetAllAsync();
            if (tables == null || tables.Count == 0)
                return Ok(new ApiResponse<object>(false, "No zones found", tables));
            return Ok(new ApiResponse<object>(true, "Zones listed successfully", tables));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var zone = await _zoneService.GetByRefAsync(@ref);
            if (zone == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Zone not found"));
            return Ok(new ApiResponse<mdlZone>(true, "Zone found", zone));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlZone zone)
        {
            if (zone == null)
                return BadRequest(new ApiResponse<object>(false, "Zone object is null").Message);
            var result = await _zoneService.AddAsync(zone);
            if (result)
                return Ok(new ApiResponse<object>(true, "Zone added successfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlZone zone)
        {
            if (zone == null || @ref != zone.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid zone data").Message);
            var existingZone = await _zoneService.GetByRefAsync(@ref);
            if (existingZone == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Zone not found"));
            var result = await _zoneService.UpdateAsync(zone);
            if (result)
                return Ok(new ApiResponse<object>(true, "Zone updated successfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingZone = await _zoneService.GetByRefAsync(@ref);
            if (existingZone == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Zone not found"));
            var result = await _zoneService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Zone deleted successfully"));
            return InternalServerError();
        }
    }
}