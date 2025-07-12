using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Stock.Ingredient;

using SnackMindModel.Model.Product.Stock.Ingredient;

namespace SnackMindData.Repository.Repository.Product.Stock.Ingredient
{
    public class IngredientStockRepository : SmRepository<mdlIngredientStock>, IIngredientStockRepository
    {
        public IngredientStockRepository(SmContext context) : base(context)
        {
            
        }
    }
}