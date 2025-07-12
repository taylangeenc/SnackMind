using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Recipe.Recipe
{
    public class dtoDetailRecipe : dtoRecipe
    {
        public string ProductName { get; set; }

        public List<dtoRecipeItem> RecipeItems { get; set; }
    }
}