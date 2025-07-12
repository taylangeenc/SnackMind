using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Place.Branch;

using SnackMindModel.Model.Place.Branch;

namespace SnackMindData.Repository.Repository.Place.Branch
{
    public class BranchRepository : SmRepository<mdlBranch>, IBranchRepository
    {
        public BranchRepository(SmContext context) : base(context)
        {
            
        }
    }
}