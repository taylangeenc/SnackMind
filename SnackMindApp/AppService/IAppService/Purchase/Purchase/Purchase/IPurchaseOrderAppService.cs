using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder;

namespace SnackMindApp.AppService.IAppService.Purchase.Purchase.Purchase
{
    public interface IPurchaseOrderAppService : ISmAppService<dtoCreatePurchaseOrder, dtoUpdatePurchaseOrder, dtoDetailPurchaseOrder, dtoListPurchaseOrder>
    {
    }
}