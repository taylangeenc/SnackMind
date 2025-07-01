using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Recipe.Ingredient;

using SnackMindModel.Product.Recipe.Ingredient;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Recipe.Ingredient
{
    public class IngredientRepository : SmRepository<mdlIngredient>, IIngredientRepository
    {
        public IngredientRepository(SmContext context) : base(context) { }
    }
}