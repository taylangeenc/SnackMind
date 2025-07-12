using SnackMindDTOs.DTOs.Product.Ingredient;
using SnackMindDTOs.DTOs.Product.Product;
using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Unit
{
    public class dtoDetailUnit : dtoUnit
    {
        public List<dtoProduct> Products { get; set; }
        public List<dtoIngredient> Ingredients { get; set; }
        public List<dtoRecipeItem> RecipeItems { get; set; }
        public List<dtoProductStock> ProductStocks { get; set; }
        public List<dtoIngredientStock> IngredientStocks { get; set; }
        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
        public List<dtoIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}