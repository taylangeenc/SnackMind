using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Category;

using SnackMindModel.Model.Product.Category;

namespace SnackMindData.Repository.Repository.Product.Category
{
    public class ParentCategoryRepository : SmRepository<mdlParentCategory>, IParentCategoryRepository
    {
        public ParentCategoryRepository(SmContext context) : base(context)
        {
            
        }
    }
}