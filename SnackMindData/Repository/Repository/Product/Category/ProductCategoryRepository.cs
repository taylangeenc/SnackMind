using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Category;

using SnackMindModel.Model.Product.Category;

namespace SnackMindData.Repository.Repository.Product.Category
{
    public class ProductCategoryRepository : SmRepository<mdlProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(SmContext context) : base(context)
        {
            
        }
    }
}