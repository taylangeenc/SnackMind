using SnackMindCore.BaseClass;

using SnackMindModel.Model.Purchase.Purchase.Ingredient;
using SnackMindModel.Model.Purchase.Purchase.Product;
using SnackMindModel.Model.Purchase.Supplier;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Purchase.Purchase.Purchase
{
    public class mdlPurchaseOrder : Entity
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }

        public Guid SupplierRef { get; set; }
        public virtual mdlSupplier Supplier { get; set; }

        public Guid PurchaseOrderStateRef { get; set; }
        public virtual mdlPurchaseOrderState PurchaseOrderState { get; set; }

        public virtual ICollection<mdlProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
        public virtual ICollection<mdlIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
    }
}