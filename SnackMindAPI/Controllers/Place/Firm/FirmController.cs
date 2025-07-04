using SnackMindAPI.Models;

using SnackMindModel.Place.Firm;

using SnackMindService.Service.ServiceBase.Place.Firm;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Place.Firm
{
    [RoutePrefix("api/firms")]
    public class FirmController : ApiController
    {
        private readonly IFirmService _firmService;
        public FirmController(IFirmService firmService)
        {
            _firmService = firmService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var firms = await _firmService.GetAllAsync();
            if (firms == null || firms.Count == 0)
                return Ok(new ApiResponse<object>(false, "No firms found", firms));
            return Ok(new ApiResponse<object>(true, "Firms listed successfully", firms));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var firms = await _firmService.GetAllAsync(x => x.IsActive);
            if (firms == null || firms.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active firms found", firms));
            return Ok(new ApiResponse<object>(true, "Active firms listed successfully", firms));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var firms = await _firmService.GetAllAsync(x => !x.IsActive);
            if (firms == null || firms.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive firms found", firms));
            return Ok(new ApiResponse<object>(true, "Passive firms listed successfully", firms));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var firm = await _firmService.GetByRefAsync(@ref);
            if (firm == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Firm not found"));
            return Ok(new ApiResponse<mdlFirm>(true, "Firm found", firm));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlFirm firm)
        {
            if (firm == null)
                return BadRequest(new ApiResponse<object>(false, "Firm object is null").Message);
            var result = await _firmService.AddAsync(firm);
            if (result)
                return Ok(new ApiResponse<object>(true, "Firm added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlFirm firm)
        {
            if (firm == null || @ref != firm.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid firm data").Message);
            var existingFirm = await _firmService.GetByRefAsync(@ref);
            if (existingFirm == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Firm not found"));
            var result = await _firmService.UpdateAsync(firm);
            if (result)
                return Ok(new ApiResponse<object>(true, "Firm updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingFirm = await _firmService.GetByRefAsync(@ref);
            if (existingFirm == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Firm not found"));
            var result = await _firmService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Firm deleted successfully"));
            return InternalServerError();
        }
    }
}