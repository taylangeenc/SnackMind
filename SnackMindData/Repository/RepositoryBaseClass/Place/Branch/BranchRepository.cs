using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Place.Branch;

using SnackMindModel.Place.Branch;

namespace SnackMindData.Repository.RepositoryBaseClass.Place.Branch
{
    public class BranchRepository : SmRepository<mdlBranch>, IBranchRepository
    {
        public BranchRepository(SmContext context) : base(context) { }
    }
}