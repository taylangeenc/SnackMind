using System;

namespace SnackMindDTOs.DTOs.Product.Recipe.RecipeItem
{
    public class dtoCreateRecipeItem
    {
        public decimal Quantity { get; set; }

        public Guid IngredientRef { get; set; }
        public Guid UnitRef { get; set; }
        public Guid RecipeRef { get; set; }

        public string Description { get; set; }
    }
}