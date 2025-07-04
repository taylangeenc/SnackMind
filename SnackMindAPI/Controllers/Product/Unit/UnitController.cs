using SnackMindAPI.Models;

using SnackMindModel.Product.Unit;

using SnackMindService.Service.ServiceBase.Product.Unit;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Product.Unit
{
    [RoutePrefix("api/units")]
    public class UnitController : ApiController
    {
        private readonly IUnitService _unitService;
        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var units = await _unitService.GetAllAsync();
            if (units == null || units.Count == 0)
                return Ok(new ApiResponse<object>(false, "No units found", units));
            return Ok(new ApiResponse<object>(true, "Units listed successfully", units));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var units = await _unitService.GetAllAsync(x => x.IsActive);
            if (units == null || units.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active units found", units));
            return Ok(new ApiResponse<object>(true, "Active units listed successfully", units));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var units = await _unitService.GetAllAsync(x => !x.IsActive);
            if (units == null || units.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive units found", units));
            return Ok(new ApiResponse<object>(true, "Passive units listed successfully", units));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var unit = await _unitService.GetByRefAsync(@ref);
            if (unit == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Unit not found"));
            return Ok(new ApiResponse<mdlUnit>(true, "Unit found", unit));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlUnit unit)
        {
            if (unit == null)
                return BadRequest(new ApiResponse<object>(false, "Unit object is null").Message);
            var result = await _unitService.AddAsync(unit);
            if (result)
                return Ok(new ApiResponse<object>(true, "Unit added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlUnit unit)
        {
            if (unit == null || @ref != unit.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid unit data").Message);
            var existingUnit = await _unitService.GetByRefAsync(@ref);
            if (existingUnit == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Unit not found"));
            var result = await _unitService.UpdateAsync(unit);
            if (result)
                return Ok(new ApiResponse<object>(true, "Unit updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingUnit = await _unitService.GetByRefAsync(@ref);
            if (existingUnit == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Unit not found"));
            var result = await _unitService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Unit deleted successfully"));
            return InternalServerError();
        }
    }
}