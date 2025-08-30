using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.User.Role;

namespace SnackMindApp.AppService.IAppService.User.Role
{
    public interface IRoleAppService : ISmAppService<dtoCreateRole, dtoUpdateRole, dtoDetailRole, dtoListRole>
    {
    }
}