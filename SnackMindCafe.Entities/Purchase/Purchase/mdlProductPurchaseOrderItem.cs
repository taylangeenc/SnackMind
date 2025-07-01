using SnackMindCore.BaseClass;

using SnackMindModel.Product.Product;

using System;

namespace SnackMindModel.Purchase.Purchase
{
    public class mdlProductPurchaseOrderItem : Entity
    {
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public Guid PurchaseOrderRef { get; set; }
        public virtual mdlPurchaseOrder PurchaseOrder { get; set; }
    }
}