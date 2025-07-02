using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Ingredient;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Ingredient
{
    public class IngredientStockMovementRepository : SmRepository<mdlIngredientStockMovement>, IIngredientStockMovementRepository
    {
        public IngredientStockMovementRepository(SmContext context) : base(context) { }
    }
}