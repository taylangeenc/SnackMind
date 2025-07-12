using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Recipe;
using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;
using SnackMindModel.Model.Product.Unit;
using SnackMindModel.Model.Purchase.Purchase.Ingredient;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Ingredient
{
    public class mdlIngredient : Entity
    {
        public string Name { get; set; }

        public decimal CostPerUnit { get; set; }
        public decimal MinStockLevel { get; set; }
        public decimal MaxStockLevel { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsPerishable { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public virtual ICollection<mdlRecipeItem> RecipeItems { get; set; }
        public virtual ICollection<mdlIngredientStock> IngredientStocks { get; set; }
        public virtual ICollection<mdlProductStockMovement> IngredientStockMovements { get; set; }
        public virtual ICollection<mdlIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
    }
}