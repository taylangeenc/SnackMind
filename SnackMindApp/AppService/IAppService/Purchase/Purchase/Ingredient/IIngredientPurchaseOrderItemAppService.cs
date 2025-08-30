using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient;

namespace SnackMindApp.AppService.IAppService.Purchase.Purchase.Ingredient
{
    public interface IIngredientPurchaseOrderItemAppService : ISmAppService<dtoCreateIngredientPurchaseOrderItem, dtoUpdateIngredientPurchaseOrderItem, dtoDetailIngredientPurchaseOrderItem, dtoListIngredientPurchaseOrderItem>
    {
    }
}