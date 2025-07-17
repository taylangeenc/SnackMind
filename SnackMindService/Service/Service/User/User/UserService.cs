using SnackMindData.UnitOfWork;

using SnackMindModel.Model.User.User;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.User.User;

namespace SnackMindService.Service.Service.User.User
{
    public class UserService : SmService<mdlUser>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.User)
        {
        }
    }
}