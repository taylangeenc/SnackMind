using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Category;

using SnackMindService.Service.ServiceBase.Product.Category;

namespace SnackMindService.Service.ServiceBaseClass.Product.Category
{
    public class mngProductCategory : SmService<mdlProductCategory>, IProductCategoryService
    {
        protected mngProductCategory(IUnitOfWork unitOfWork, ISmRepository<mdlProductCategory> repository) : base(unitOfWork, repository)
        {
        }
    }
}