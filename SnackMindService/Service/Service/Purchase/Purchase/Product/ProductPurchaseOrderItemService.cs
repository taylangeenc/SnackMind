using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Purchase.Purchase.Product;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Purchase.Purchase.Product;

namespace SnackMindService.Service.Service.Purchase.Purchase.Product
{
    public class ProductPurchaseOrderItemService : SmService<mdlProductPurchaseOrderItem>, IProductPurchaseOrderItemService
    {
        public ProductPurchaseOrderItemService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ProductPurchaseOrderItem)
        {
        }
    }
}