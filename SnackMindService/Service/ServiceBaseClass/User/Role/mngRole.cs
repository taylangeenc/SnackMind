using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.User.Role;

using SnackMindService.Service.ServiceBase.User.Role;

namespace SnackMindService.Service.ServiceBaseClass.User.Role
{
    public class mngRole : SmService<mdlRole>, IRoleService
    {
        protected mngRole(IUnitOfWork unitOfWork, ISmRepository<mdlRole> repository) : base(unitOfWork, repository)
        {
        }
    }
}