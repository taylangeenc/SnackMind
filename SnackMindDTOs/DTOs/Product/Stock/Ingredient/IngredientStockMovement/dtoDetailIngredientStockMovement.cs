using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;

namespace SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement
{
    public class dtoDetailIngredientStockMovement : dtoIngredientStockMovement
    {
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }
        public string UserName { get; set; }
        public string StockMovementTypeName { get; set; }

        public dtoIngredientStock IngredientStock { get; set; }
    }
}