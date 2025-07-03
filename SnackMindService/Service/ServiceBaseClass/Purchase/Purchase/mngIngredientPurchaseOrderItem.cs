using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Purchase.Purchase;

using SnackMindService.Service.ServiceBase.Purchase.Purchase;

namespace SnackMindService.Service.ServiceBaseClass.Purchase.Purchase
{
    public class mngIngredientPurchaseOrderItem : SmService<mdlIngredientPurchaseOrderItem>, IIngredientPurchaseOrderItemService
    {
        protected mngIngredientPurchaseOrderItem(IUnitOfWork unitOfWork, ISmRepository<mdlIngredientPurchaseOrderItem> repository) : base(unitOfWork, repository)
        {
        }
    }
}