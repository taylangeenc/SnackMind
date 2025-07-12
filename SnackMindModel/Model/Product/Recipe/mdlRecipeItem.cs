using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Ingredient;
using SnackMindModel.Model.Product.Unit;

using System;

namespace SnackMindModel.Model.Product.Recipe
{
    public class mdlRecipeItem : Entity
    {
        public decimal Quantity { get; set; }

        public Guid IngredientRef { get; set; }
        public virtual mdlIngredient Ingredient { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public Guid RecipeRef { get; set; }
        public virtual mdlRecipe Recipe { get; set; }

    }
}