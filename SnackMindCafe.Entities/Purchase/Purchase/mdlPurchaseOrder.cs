using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Purchase.Supplier;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Purchase.Purchase
{
    public class mdlPurchaseOrder : Entity
    {
        public string Description { get; set; }
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