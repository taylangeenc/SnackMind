using SnackMindCore.BaseClass;

using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Variant
{
    public class mdlProductVariant : Entity
    {
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
    }
}