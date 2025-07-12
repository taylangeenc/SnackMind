using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Ingredient;
using SnackMindModel.Model.Purchase.Purchase.Purchase;

using System;

namespace SnackMindModel.Model.Purchase.Purchase.Ingredient
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