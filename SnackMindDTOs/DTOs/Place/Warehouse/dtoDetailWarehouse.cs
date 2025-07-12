using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Place.Warehouse
{
    public class dtoDetailWarehouse : dtoWarehouse
    {
        public string FirmName { get; set; }

        public List<dtoProductStock> ProductStocks { get; set; }
        public List<dtoIngredientStock> IngredientStocks { get; set; }
        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
        public List<dtoIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}