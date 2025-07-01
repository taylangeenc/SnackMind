using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.User.Role;

using SnackMindModel.User.Role;

namespace SnackMindData.Repository.RepositoryBaseClass.User.Role
{
    public class RoleRepository : SmRepository<mdlRole>, IRoleRepository
    {
        public RoleRepository(SmContext context) : base(context) { }
    }
}