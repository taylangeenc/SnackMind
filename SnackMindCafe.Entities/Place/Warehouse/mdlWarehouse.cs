using SnackMindCore.BaseClass;

using SnackMindModel.Place.Branch;
using SnackMindModel.Product.Stock;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Place.Warehouse
{
    public class mdlWarehouse : EntityCard
    {
        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public virtual ICollection<mdlProductStock> ProductStocks { get; set; }
        public virtual ICollection<mdlIngredientStock> IngredientStocks { get; set; }
        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}