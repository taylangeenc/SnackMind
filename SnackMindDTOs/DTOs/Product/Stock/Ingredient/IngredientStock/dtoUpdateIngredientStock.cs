using System;

namespace SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock
{
    public class dtoUpdateIngredientStock
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }

        public Guid IngredientRef { get; set; }
        public Guid UnitRef { get; set; }
        public Guid WarehouseRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}