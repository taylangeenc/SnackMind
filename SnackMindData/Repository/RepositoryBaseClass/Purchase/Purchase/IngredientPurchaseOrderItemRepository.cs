using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Purchase.Purchase;

using SnackMindModel.Purchase.Purchase;

namespace SnackMindData.Repository.RepositoryBaseClass.Purchase.Purchase
{
    public class IngredientPurchaseOrderItemRepository : SmRepository<mdlIngredientPurchaseOrderItem>, IIngredientPurchaseOrderItemRepository
    {
        public IngredientPurchaseOrderItemRepository(SmContext context) : base(context) { }
    }
}