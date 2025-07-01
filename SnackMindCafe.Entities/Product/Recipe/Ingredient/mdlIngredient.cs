using SnackMindCore.BaseClass;

using SnackMindModel.Product.Recipe.Recipe;
using SnackMindModel.Product.Stock;
using SnackMindModel.Product.Unit;
using SnackMindModel.Purchase.Purchase;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Recipe.Ingredient
{
    public class mdlIngredient : EntityCard
    {
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