using SnackMindAPI.Models;
using SnackMindModel.User.CashShift;
using SnackMindService.Service.ServiceBase.User.CashShift;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.User.CashShift
{
    [RoutePrefix("api/cashshifts")]
    public class CashShiftController : ApiController
    {
        private readonly ICashShiftService _cashShiftService;
        public CashShiftController(ICashShiftService cashShiftService)
        {
            _cashShiftService = cashShiftService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var cashShifts = await _cashShiftService.GetAllAsync();
            if (cashShifts == null || cashShifts.Count == 0)
                return Ok(new ApiResponse<object>(false, "No cash shifts found", cashShifts));
            return Ok(new ApiResponse<object>(true, "Cash shifts listed successfully", cashShifts));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var cashShift = await _cashShiftService.GetByRefAsync(@ref);
            if (cashShift == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Cash shift not found"));
            return Ok(new ApiResponse<mdlCashShift>(true, "Cash shift found", cashShift));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlCashShift cashShift)
        {
            if (cashShift == null)
                return BadRequest(new ApiResponse<object>(false, "Cash shift object is null").Message);
            var result = await _cashShiftService.AddAsync(cashShift);
            if (result)
                return Ok(new ApiResponse<object>(true, "Cash shift added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlCashShift cashShift)
        {
            if (cashShift == null || @ref != cashShift.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid cash shift data").Message);
            var existingCashShift = await _cashShiftService.GetByRefAsync(@ref);
            if (existingCashShift == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Cash shift not found"));
            var result = await _cashShiftService.UpdateAsync(cashShift);
            if (result)
                return Ok(new ApiResponse<object>(true, "Cash shift updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingCashShift = await _cashShiftService.GetByRefAsync(@ref);
            if (existingCashShift == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Cash shift not found"));
            var result = await _cashShiftService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Cash shift deleted successfully"));
            return InternalServerError();
        }
    }
}