using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Product;

using SnackMindModel.Model.Purchase.Purchase.Product;

namespace SnackMindData.Repository.Repository.Purchase.Purchase.Product
{
    public class ProductPurchaseOrderItemRepository : SmRepository<mdlProductPurchaseOrderItem>, IProductPurchaseOrderItemRepository
    {
        public ProductPurchaseOrderItemRepository(SmContext context) : base(context)
        {
            
        }
    }
}