using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Recipe.Recipe;

namespace SnackMindApp.AppService.IAppService.Product.Recipe
{
    public interface IRecipeAppService : ISmAppService<dtoCreateRecipe, dtoUpdateRecipe, dtoDetailRecipe, dtoListRecipe>
    {
    }
}