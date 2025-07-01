using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Category;

using SnackMindModel.Product.Category;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Category
{
    public class ParentCategoryRepository : SmRepository<mdlParentCategory>, IParentCategoryRepository
    {
        public ParentCategoryRepository(SmContext context) : base(context) { }
    }
}