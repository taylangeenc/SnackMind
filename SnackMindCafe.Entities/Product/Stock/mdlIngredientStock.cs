using SnackMindCore.BaseClass;

using SnackMindModel.Place.Warehouse;
using SnackMindModel.Product.Recipe.Ingredient;
using SnackMindModel.Product.Unit;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Stock
{
    public class mdlIngredientStock : Entity
    {
        public decimal Quantity { get; set; }

        public Guid IngredientRef { get; set; }
        public virtual mdlIngredient Ingredient { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public Guid WarehouseRef { get; set; }
        public virtual mdlWarehouse Warehouse { get; set; }

        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}