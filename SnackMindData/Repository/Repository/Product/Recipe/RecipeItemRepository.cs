using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Recipe;

using SnackMindModel.Model.Product.Recipe;

namespace SnackMindData.Repository.Repository.Product.Recipe
{
    public class RecipeItemRepository : SmRepository<mdlRecipeItem>, IRecipeItemRepository
    {
        public RecipeItemRepository(SmContext context) : base(context)
        {

        }
    }
}