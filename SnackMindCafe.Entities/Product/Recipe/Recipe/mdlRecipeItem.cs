using SnackMindCore.BaseClass;

using SnackMindModel.Product.Recipe.Ingredient;
using SnackMindModel.Product.Unit;

using System;
using System.Xml;

namespace SnackMindModel.Product.Recipe.Recipe
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