using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Category;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Category;

namespace SnackMindService.Service.Service.Product.Category
{
    public class ProductCategoryService : SmService<mdlProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ProductCategory)
        {

        }
    }
}