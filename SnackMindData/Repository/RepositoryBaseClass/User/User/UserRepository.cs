using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.User.User;

using SnackMindModel.User.User;

namespace SnackMindData.Repository.RepositoryBaseClass.User.User
{
    public class UserRepository : SmRepository<mdlUser>, IUserRepository
    {
        public UserRepository(SmContext context) : base(context) { }
    }
}