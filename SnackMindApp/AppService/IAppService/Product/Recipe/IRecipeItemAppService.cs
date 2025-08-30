using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;

namespace SnackMindApp.AppService.IAppService.Product.Recipe
{
    public interface IRecipeItemAppService : ISmAppService<dtoCreateRecipeItem, dtoUpdateRecipeItem, dtoDetailRecipeItem, dtoListRecipeItem>
    {
    }
}