using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;
using SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Ingredient
{
    public class dtoDetailIngredient : dtoIngredient
    {
        public string UnitName { get; set; }

        public List<dtoRecipeItem> RecipeItems { get; set; }
        public List<dtoIngredientStock> IngredientStocks { get; set; }
        public List<dtoProductStockMovement> IngredientStockMovements { get; set; }
        public List<dtoIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
    }
}