using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Ingredient;
using SnackMindModel.Model.Product.Product;
using SnackMindModel.Model.Product.Recipe;
using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;

using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Unit
{
    public class mdlUnit : Entity
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool IsDefault { get; set; }

        public ICollection<mdlProduct> Products { get; set; }
        public ICollection<mdlIngredient> Ingredients { get; set; }
        public ICollection<mdlRecipeItem> RecipeItems { get; set; }
        public ICollection<mdlProductStock> ProductStocks { get; set; }
        public ICollection<mdlIngredientStock> IngredientStocks { get; set; }
        public ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }

    }
}