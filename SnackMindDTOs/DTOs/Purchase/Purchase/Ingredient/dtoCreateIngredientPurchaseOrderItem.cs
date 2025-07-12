using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient
{
    public class dtoCreateIngredientPurchaseOrderItem
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid IngredientRef { get; set; }
        public Guid PurchaseOrderRef { get; set; }

        public string Description { get; set; }
    }
}