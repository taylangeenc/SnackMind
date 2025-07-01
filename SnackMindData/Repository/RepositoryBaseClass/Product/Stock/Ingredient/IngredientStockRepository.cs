using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Ingredient;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Ingredient
{
    public class IngredientStockRepository : SmRepository<mdlIngredientStock>, IIngredientStockRepository
    {
        public IngredientStockRepository(SmContext context) : base(context) { }
    }
}