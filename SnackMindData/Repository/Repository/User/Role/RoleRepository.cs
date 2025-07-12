using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.User.Role;

using SnackMindModel.Model.User.Role;

namespace SnackMindData.Repository.Repository.User.Role
{
    public class RoleRepository : SmRepository<mdlRole>, IRoleRepository
    {
        public RoleRepository(SmContext context) : base(context)
        {
            
        }
    }
}