using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrderState;

namespace SnackMindApp.AppService.IAppService.Purchase.Purchase.Purchase
{
    public interface IPurchaseOrderStateAppService : ISmAppService<dtoCreatePurchaseOrderState, dtoUpdatePurchaseOrderState, dtoDetailPurchaseOrderState, dtoListPurchaseOrderState>
    {
    }
}