using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Ingredient;

namespace SnackMindApp.AppService.IAppService.Product.Ingredient
{
    public interface IIngredientAppService : ISmAppService<dtoCreateIngredient, dtoUpdateIngredient, dtoDetailIngredient, dtoListIngredient>
    {
    }
}