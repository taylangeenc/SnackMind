using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Purchase.Purchase.Product;

namespace SnackMindApp.AppService.IAppService.Purchase.Purchase.Product
{
    public interface IProductPurchaseOrderItemAppService : ISmAppService<dtoCreateProductPurchaseOrderItem, dtoUpdateProductPurchaseOrderItem, dtoDetailProductPurchaseOrderItem, dtoListProductPurchaseOrderItem>
    {
    }
}