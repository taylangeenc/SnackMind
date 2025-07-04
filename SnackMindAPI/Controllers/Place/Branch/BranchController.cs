using SnackMindAPI.Models;

using SnackMindModel.Place.Branch;

using SnackMindService.Service.ServiceBase.Place.Branch;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.Place.Branch
{
    [RoutePrefix("api/branches")]
    public class BranchController : ApiController
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var branches = await _branchService.GetAllAsync();
            if (branches == null || branches.Count == 0)
                return Ok(new ApiResponse<object>(false, "No branches found", branches));
            return Ok(new ApiResponse<object>(true, "Branches listed successfully", branches));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var branches = await _branchService.GetAllAsync(x => x.IsActive);
            if (branches == null || branches.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active branches found", branches));
            return Ok(new ApiResponse<object>(true, "Active branches listed successfully", branches));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var branches = await _branchService.GetAllAsync(x => !x.IsActive);
            if (branches == null || branches.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive branches found", branches));
            return Ok(new ApiResponse<object>(true, "Passive branches listed successfully", branches));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var branch = await _branchService.GetByRefAsync(@ref);
            if (branch == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Branch not found"));
            return Ok(new ApiResponse<mdlBranch>(true, "Branch found", branch));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlBranch branch)
        {
            if (branch == null)
                return BadRequest(new ApiResponse<object>(false, "Branch object is null").Message);
            var result = await _branchService.AddAsync(branch);
            if (result)
                return Ok(new ApiResponse<object>(true, "Branch added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlBranch branch)
        {
            if (branch == null || @ref != branch.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid branch data").Message);
            var existingBranch = await _branchService.GetByRefAsync(@ref);
            if (existingBranch == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Branch not found"));
            var result = await _branchService.UpdateAsync(branch);
            if (result)
                return Ok(new ApiResponse<object>(true, "Branch updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingBranch = await _branchService.GetByRefAsync(@ref);
            if (existingBranch == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "Branch not found"));
            var result = await _branchService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Branch deleted successfully"));
            return InternalServerError();
        }
    }
}