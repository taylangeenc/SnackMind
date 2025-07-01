using SnackMindCore.BaseClass;

using SnackMindModel.Order.Order;
using SnackMindModel.Product.Category;
using SnackMindModel.Product.Recipe.Recipe;
using SnackMindModel.Product.Stock;
using SnackMindModel.Product.Unit;
using SnackMindModel.Product.Variant;
using SnackMindModel.Purchase.Purchase;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Product
{
    public class mdlProduct : EntityCard
    {
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