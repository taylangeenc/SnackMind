using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Recipe;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Recipe;

namespace SnackMindService.Service.Service.Product.Recipe
{
    public class RecipeItemService : SmService<mdlRecipeItem>, IRecipeItemService
    {
        public RecipeItemService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.RecipeItem)
        {
        }
    }
}