using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Purchase.Purchase;

using SnackMindService.Service.ServiceBase.Purchase.Purchase;

namespace SnackMindService.Service.ServiceBaseClass.Purchase.Purchase
{
    public class mngPurchaseOrder : SmService<mdlPurchaseOrder>, IPurchaseOrderService
    {
        protected mngPurchaseOrder(IUnitOfWork unitOfWork, ISmRepository<mdlPurchaseOrder> repository) : base(unitOfWork, repository)
        {
        }
    }
}