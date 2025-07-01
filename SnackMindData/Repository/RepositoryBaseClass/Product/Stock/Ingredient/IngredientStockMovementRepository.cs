using SnackMindData.Context;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Ingredient
{
    public class IngredientStockMovementRepository : SmRepository<mdlIngredientStockMovement>
    {
        public IngredientStockMovementRepository(SmContext context) : base(context) { }
    }
}