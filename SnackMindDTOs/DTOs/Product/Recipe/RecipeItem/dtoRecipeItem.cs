using System;

namespace SnackMindDTOs.DTOs.Product.Recipe.RecipeItem
{
    public class dtoRecipeItem
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }

        public Guid IngredientRef { get; set; }
        public Guid UnitRef { get; set; }
        public Guid RecipeRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}