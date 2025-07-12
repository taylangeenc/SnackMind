using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient
{
    public class dtoIngredientPurchaseOrderItem
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid IngredientRef { get; set; }
        public Guid PurchaseOrderRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}