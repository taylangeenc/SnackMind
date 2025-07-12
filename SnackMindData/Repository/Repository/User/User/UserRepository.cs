using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.User.User;

using SnackMindModel.Model.User.User;

namespace SnackMindData.Repository.Repository.User.User
{
    public class UserRepository : SmRepository<mdlUser>, IUserRepository
    {
        public UserRepository(SmContext context) : base(context)
        {
            
        }
    }
}