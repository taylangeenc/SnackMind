using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Category;

using SnackMindService.Service.ServiceBase.Product.Category;

namespace SnackMindService.Service.ServiceBaseClass.Product.Category
{
    public class mngParentCategory : SmService<mdlParentCategory>, IParentCategoryService
    {
        protected mngParentCategory(IUnitOfWork unitOfWork, ISmRepository<mdlParentCategory> repository) : base(unitOfWork, repository)
        {
        }
    }
}