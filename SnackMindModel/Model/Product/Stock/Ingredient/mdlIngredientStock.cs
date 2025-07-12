using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Warehouse;
using SnackMindModel.Model.Product.Ingredient;
using SnackMindModel.Model.Product.Unit;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Stock.Ingredient
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