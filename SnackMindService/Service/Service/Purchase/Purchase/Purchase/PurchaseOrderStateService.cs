using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Purchase.Purchase.Purchase;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Purchase.Purchase.Purchase;

namespace SnackMindService.Service.Service.Purchase.Purchase.Purchase
{
    public class PurchaseOrderStateService : SmService<mdlPurchaseOrderState>, IPurchaseOrderStateService
    {
        public PurchaseOrderStateService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PurchaseOrderState)
        {
        }
    }
}