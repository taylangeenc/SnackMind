using SnackMindAPI.Models;

using SnackMindModel.User.User;

using SnackMindService.Service.ServiceBase.User.User;

using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SnackMindAPI.Controllers.User.User
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            if (users == null || users.Count == 0)
                return Ok(new ApiResponse<object>(false, "No users found", users));
            return Ok(new ApiResponse<object>(true, "Users listed successfully", users));
        }

        [HttpGet]
        [Route("active")]
        public async Task<IHttpActionResult> GetActive()
        {
            var users = await _userService.GetAllAsync(x => x.IsActive);
            if (users == null || users.Count == 0)
                return Ok(new ApiResponse<object>(false, "No active users found", users));
            return Ok(new ApiResponse<object>(true, "Active users listed successfully", users));
        }

        [HttpGet]
        [Route("passive")]
        public async Task<IHttpActionResult> GetPassive()
        {
            var users = await _userService.GetAllAsync(x => !x.IsActive);
            if (users == null || users.Count == 0)
                return Ok(new ApiResponse<object>(false, "No passive users found", users));
            return Ok(new ApiResponse<object>(true, "Passive users listed successfully", users));
        }

        [HttpGet]
        [Route("getbyref/{ref:guid}")]
        public async Task<IHttpActionResult> GetByRef(Guid @ref)
        {
            var user = await _userService.GetByRefAsync(@ref);
            if (user == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "User not found"));
            return Ok(new ApiResponse<mdlUser>(true, "User found", user));
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Add([FromBody] mdlUser user)
        {
            if (user == null)
                return BadRequest(new ApiResponse<object>(false, "User object is null").Message);
            var result = await _userService.AddAsync(user);
            if (result)
                return Ok(new ApiResponse<object>(true, "User added successfully"));
            return InternalServerError();
        }

        [HttpPut]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Update(Guid @ref, [FromBody] mdlUser user)
        {
            if (user == null || @ref != user.Ref)
                return BadRequest(new ApiResponse<object>(false, "Invalid user data").Message);
            var existingUser = await _userService.GetByRefAsync(@ref);
            if (existingUser == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "User not found"));
            var result = await _userService.UpdateAsync(user);
            if (result)
                return Ok(new ApiResponse<object>(true, "User updated successfully"));
            return InternalServerError();
        }

        [HttpDelete]
        [Route("{ref:guid}")]
        public async Task<IHttpActionResult> Delete(Guid @ref)
        {
            var existingUser = await _userService.GetByRefAsync(@ref);
            if (existingUser == null)
                return Content(System.Net.HttpStatusCode.NotFound, new ApiResponse<object>(false, "User not found"));
            var result = await _userService.DeleteAsync(@ref);
            if (result)
                return Ok(new ApiResponse<object>(true, "User deleted successfully"));
            return InternalServerError();
        }
    }
}