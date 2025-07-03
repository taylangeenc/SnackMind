using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Purchase.Purchase;

using SnackMindService.Service.ServiceBase.Purchase.Purchase;

namespace SnackMindService.Service.ServiceBaseClass.Purchase.Purchase
{
    public class mngProductPurchaseOrderItem : SmService<mdlProductPurchaseOrderItem>, IProductPurchaseOrderItemService
    {
        protected mngProductPurchaseOrderItem(IUnitOfWork unitOfWork, ISmRepository<mdlProductPurchaseOrderItem> repository) : base(unitOfWork, repository)
        {
        }
    }
}