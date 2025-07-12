using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Stock.StockMovementType
{
    public class dtoDetailStockMovementType : dtoStockMovementType
    {
        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
        public List<dtoIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}