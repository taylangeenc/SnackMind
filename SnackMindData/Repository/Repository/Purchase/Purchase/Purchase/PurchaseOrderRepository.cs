using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Purchase;

using SnackMindModel.Model.Purchase.Purchase.Purchase;

namespace SnackMindData.Repository.Repository.Purchase.Purchase.Purchase
{
    public class PurchaseOrderRepository : SmRepository<mdlPurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(SmContext context) : base(context)
        {
            
        }
    }
}