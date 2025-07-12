using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock
{
    public class dtoDetailIngredientStock : dtoIngredientStock
    {
        public string IngredientName { get; set; }
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }

        public List<dtoIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}