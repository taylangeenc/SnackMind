using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;

namespace SnackMindApp.AppService.IAppService.Product.Stock.Ingredient
{
    public interface IIngredientStockMovementAppService : ISmAppService<dtoCreateIngredientStockMovement, dtoUpdateIngredientStockMovement, dtoDetailIngredientStockMovement, dtoListIngredientStockMovement>
    {
    }
}