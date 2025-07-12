using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Ingredient;

using SnackMindModel.Model.Product.Ingredient;

namespace SnackMindData.Repository.Repository.Product.Ingredient
{
    public class IngredientRepository : SmRepository<mdlIngredient>, IIngredientRepository
    {
        public IngredientRepository(SmContext context) : base(context)
        {
            
        }
    }
}