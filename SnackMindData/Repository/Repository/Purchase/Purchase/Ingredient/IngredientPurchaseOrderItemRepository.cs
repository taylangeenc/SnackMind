using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Ingredient;

using SnackMindModel.Model.Purchase.Purchase.Ingredient;

namespace SnackMindData.Repository.Repository.Purchase.Purchase.Ingredient
{
    public class IngredientPurchaseOrderItemRepository : SmRepository<mdlIngredientPurchaseOrderItem>, IIngredientPurchaseOrderItemRepository
    {
        public IngredientPurchaseOrderItemRepository(SmContext context) : base(context)
        {
            
        }
    }
}