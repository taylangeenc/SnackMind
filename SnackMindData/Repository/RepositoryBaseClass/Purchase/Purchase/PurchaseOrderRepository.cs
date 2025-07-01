using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Purchase.Purchase;

using SnackMindModel.Purchase.Purchase;

namespace SnackMindData.Repository.RepositoryBaseClass.Purchase.Purchase
{
    public class PurchaseOrderRepository : SmRepository<mdlPurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(SmContext context) : base(context) { }
    }
}