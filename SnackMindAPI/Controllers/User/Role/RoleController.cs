using SnackMindAPI.Models;

using SnackMindModel.User.Role;

using SnackMindService.Service.ServiceBase.User.Role;

using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.User.Role
{
    public class RoleController : ApiController
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var roles = await _roleService.GetAllAsync();
            if (roles == null || roles.Count == 0)
                return Ok(new ApiResponse<object>(false, "No roles found", roles));
            return Ok(new ApiResponse<object>(true, "Roles listed succesfully", roles));
        }
        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var roles = await _roleService.GetAllAsync(x => x.IsActive);
            if (roles == null || roles.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active roles found", roles));
            return Ok(new ApiResponse<object>(true, "Active roles listed succesfully", roles));
        }
        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var roles = await _roleService.GetAllAsync(x => !x.IsActive);
            if (roles == null || roles.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive roles found", roles));
            return Ok(new ApiResponse<object>(true, "Passive roles listed succesfully", roles));
        }
        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var role = await _roleService.GetByRefAsync(@ref);
            if (role == null)
                return Content(HttpStatusCode.NotFound, new ApiResponse<mdlRole>(false, "Role not found"));
            return Ok(new ApiResponse<mdlRole>(true, "Role found", role));
        }
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlRole role)
        {
            if (role == null)
                return BadRequest(new ApiResponse<mdlRole>(false, "Invalid role data", role).Message);
            var result = await _roleService.AddAsync(role);
            if (result)
                return Ok(new ApiResponse<mdlRole>(true, "Role added succesfully"));
            return InternalServerError();
        }
        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlRole role)
        {
            if (role == null)
                return BadRequest(new ApiResponse<object>(false, "Invalid role data").Message);
            var existingRole = await _roleService.GetByRefAsync(@ref);
            if (existingRole == null)
                return Content(HttpStatusCode.NotFound, new ApiResponse<object>(false, "Role not found"));
            var result = await _roleService.UpdateAsync(role);
            if (result)
                return Ok(new ApiResponse<mdlRole>(true, "Role updated succesfully"));
            return InternalServerError();
        }
        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var role = await _roleService.GetByRefAsync(@ref);
            if (role == null)
                return Content(HttpStatusCode.NotFound, new ApiResponse<object>(false, "Role not found"));
            var result = await _roleService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "Role deleted succesfully"));
            return InternalServerError();
        }
    }
}