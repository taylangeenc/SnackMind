using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Category;

using SnackMindModel.Product.Category;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Category
{
    public class ProductCategoryRepository : SmRepository<mdlProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(SmContext context) : base(context) { }
    }
}