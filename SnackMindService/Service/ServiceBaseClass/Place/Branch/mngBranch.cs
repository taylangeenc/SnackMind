using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Place.Branch;

using SnackMindService.Service.ServiceBase.Place.Branch;

namespace SnackMindService.Service.ServiceBaseClass.Place.Branch
{
    public class mngBranch : SmService<mdlBranch>, IBranchService
    {
        protected mngBranch(IUnitOfWork unitOfWork, ISmRepository<mdlBranch> repository) : base(unitOfWork, repository)
        {
        }
    }
}