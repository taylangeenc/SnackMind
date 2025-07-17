using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Recipe;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Recipe;

namespace SnackMindService.Service.Service.Product.Recipe
{
    public class RecipeService : SmService<mdlRecipe>, IRecipeService
    {
        public RecipeService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Recipe)
        {
        }
    }
}