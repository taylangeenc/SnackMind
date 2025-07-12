using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Product;
using SnackMindModel.Model.Product.Variant;

using System;

namespace SnackMindModel.Model.Order.Order
{
    public class mdlOrderItem : Entity
    {
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsPrintedToKitchen { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public Guid ProductVariantRef { get; set; }
        public virtual mdlProductVariant ProductVariant { get; set; }

        public Guid OrderRef { get; set; }
        public virtual mdlOrder Order { get; set; }

        public Guid OrderItemStateRef { get; set; }
        public virtual mdlOrderItemState OrderItemState { get; set; }
    }
}