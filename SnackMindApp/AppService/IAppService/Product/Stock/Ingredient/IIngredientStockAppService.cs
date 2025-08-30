using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;

namespace SnackMindApp.AppService.IAppService.Product.Stock.Ingredient
{
    public interface IIngredientStockAppService : ISmAppService<dtoCreateIngredientStock, dtoUpdateIngredientStock, dtoDetailIngredientStock, dtoListIngredientStock>
    {
    }
}