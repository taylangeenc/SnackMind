using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.User.User;

using SnackMindService.Service.ServiceBase.User.User;

namespace SnackMindService.Service.ServiceBaseClass.User.User
{
    public class mngUser : SmService<mdlUser>, IUserService
    {
        protected mngUser(IUnitOfWork unitOfWork, ISmRepository<mdlUser> repository) : base(unitOfWork, repository)
        {
        }
    }
}