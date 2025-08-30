using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.User.User;

namespace SnackMindApp.AppService.IAppService.User.User
{
    public interface IUserAppService : ISmAppService<dtoCreateUser, dtoUpdateUser, dtoDetailUser, dtoListUser>
    {
    }
}