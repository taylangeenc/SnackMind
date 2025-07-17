using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Purchase.Purchase.Purchase;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Purchase.Purchase.Purchase;

namespace SnackMindService.Service.Service.Purchase.Purchase.Purchase
{
    public class PurchaseOrderService : SmService<mdlPurchaseOrder>, IPurchaseOrderService
    {
        public PurchaseOrderService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PurchaseOrder)
        {
        }
    }
}