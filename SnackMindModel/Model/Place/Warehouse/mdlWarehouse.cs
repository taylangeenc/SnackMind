using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Place.Warehouse
{
    public class mdlWarehouse : Entity
    {
        public string Name { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public virtual ICollection<mdlProductStock> ProductStocks { get; set; }
        public virtual ICollection<mdlIngredientStock> IngredientStocks { get; set; }
        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}