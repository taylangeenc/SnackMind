using System;

namespace SnackMindDTOs.DTOs.Product.Ingredient
{
    public class dtoUpdateIngredient
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public decimal CostPerUnit { get; set; }
        public decimal MinStockLevel { get; set; }
        public decimal MaxStockLevel { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsPerishable { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public Guid UnitRef { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}