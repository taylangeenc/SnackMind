using SnackMindCore.BaseClass;

using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Product.Category;
using SnackMindModel.Model.Product.Recipe;
using SnackMindModel.Model.Product.Stock.Product;
using SnackMindModel.Model.Product.Unit;
using SnackMindModel.Model.Product.Variant;
using SnackMindModel.Model.Purchase.Purchase.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Product
{
    public class mdlProduct : Entity
    {
        public string Name { get; set; }
        public string StockCode { get; set; }
        public string ImagePath { get; set; }
        public string Barcode { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TaxRate { get; set; }
        public bool IsComposite { get; set; }

        public Guid CategoryRef { get; set; }
        public virtual mdlProductCategory Category { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public virtual ICollection<mdlProductVariant> ProductVariants { get; set; }
        public virtual ICollection<mdlRecipe> Recipes { get; set; }
        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
        public virtual ICollection<mdlProductStock> ProductStocks { get; set; }
        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
    }
}