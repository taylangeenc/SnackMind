using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Recipe.Recipe;

using SnackMindModel.Product.Recipe.Recipe;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Recipe.Recipe
{
    public class RecipeItemRepository : SmRepository<mdlRecipeItem>, IRecipeItemRepository
    {
        public RecipeItemRepository(SmContext context) : base(context) { }
    }
}