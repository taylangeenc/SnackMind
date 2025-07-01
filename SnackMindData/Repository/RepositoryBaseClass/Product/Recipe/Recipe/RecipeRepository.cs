using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Recipe.Recipe;

using SnackMindModel.Product.Recipe.Recipe;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Recipe.Recipe
{
    public class RecipeRepository : SmRepository<mdlRecipe>, IRecipeRepository
    {
        public RecipeRepository(SmContext context) : base(context) { }
    }
}