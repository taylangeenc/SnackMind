using SnackMindCore.BaseClass;

using SnackMindModel.Product.Product;
using SnackMindModel.Product.Recipe.Ingredient;
using SnackMindModel.Product.Recipe.Recipe;
using SnackMindModel.Product.Stock;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Unit
{
    public class mdlUnit : EntityCard
    {
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