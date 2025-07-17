using SnackMindData.UnitOfWork;

using SnackMindModel.Model.User.Role;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.User.Role;

namespace SnackMindService.Service.Service.User.Role
{
    public class RoleService : SmService<mdlRole>, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Role)
        {
        }
    }
}