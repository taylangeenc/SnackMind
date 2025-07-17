using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Purchase.Purchase.Ingredient;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Purchase.Purchase.Ingredient;

namespace SnackMindService.Service.Service.Purchase.Purchase.Ingredient
{
    public class IngredientPurchaseOrderItemService : SmService<mdlIngredientPurchaseOrderItem>, IIngredientPurchaseOrderItemService
    {
        public IngredientPurchaseOrderItemService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.IngredientPurchaseOrderItem)
        {
        }
    }
}