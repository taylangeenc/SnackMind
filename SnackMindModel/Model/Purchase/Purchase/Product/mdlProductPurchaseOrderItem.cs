using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Product;
using SnackMindModel.Model.Purchase.Purchase.Purchase;

using System;

namespace SnackMindModel.Model.Purchase.Purchase.Product
{
    public class mdlProductPurchaseOrderItem : Entity
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public Guid PurchaseOrderRef { get; set; }
        public virtual mdlPurchaseOrder PurchaseOrder { get; set; }
    }
}