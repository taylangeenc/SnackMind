using SnackMindCore.BaseClass;

using SnackMindModel.Order.Order;
using SnackMindModel.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Variant
{
    public class mdlProductVariant : EntityCard
    {
        public decimal ExtraPrice { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
    }
}