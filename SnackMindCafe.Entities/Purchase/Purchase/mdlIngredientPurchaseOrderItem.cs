using SnackMindCore.BaseClass;

using SnackMindModel.Product.Recipe.Ingredient;

using System;

namespace SnackMindModel.Purchase.Purchase
{
    public class mdlIngredientPurchaseOrderItem : Entity
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid IngredientRef { get; set; }
        public virtual mdlIngredient Ingredient { get; set; }

        public Guid PurchaseOrderRef { get; set; }
        public virtual mdlPurchaseOrder PurchaseOrder { get; set; }
    }
}