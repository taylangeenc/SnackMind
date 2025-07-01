using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Purchase.Purchase;

using SnackMindModel.Purchase.Purchase;

namespace SnackMindData.Repository.RepositoryBaseClass.Purchase.Purchase
{
    public class ProductPurchaseOrderItemRepository : SmRepository<mdlProductPurchaseOrderItem>, IProductPurchaseOrderItemRepository
    {
        public ProductPurchaseOrderItemRepository(SmContext context) : base(context) { }
    }
}