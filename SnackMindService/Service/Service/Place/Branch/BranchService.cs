using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Place.Branch;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Place.Branch;

namespace SnackMindService.Service.Service.Place.Branch
{
    public class BranchService : SmService<mdlBranch>, IBranchService
    {
        public BranchService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Branch)
        {

        }
    }
}