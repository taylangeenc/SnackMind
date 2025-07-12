using System;

namespace SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement
{
    public class dtoCreateIngredientStockMovement
    {
        public decimal Quantity { get; set; }
        public DateTime MovementDate { get; set; }

        public Guid IngredientStockRef { get; set; }
        public Guid UnitRef { get; set; }
        public Guid WarehouseRef { get; set; }
        public Guid UserRef { get; set; }
        public Guid StockMovementTypeRef { get; set; }

        public string Description { get; set; }
    }
}