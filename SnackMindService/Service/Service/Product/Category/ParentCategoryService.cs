using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Category;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Category;

namespace SnackMindService.Service.Service.Product.Category
{
    public class ParentCategoryService : SmService<mdlParentCategory>, IParentCategoryService
    {
        public ParentCategoryService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ParentCategory)
        {

        }
    }
}