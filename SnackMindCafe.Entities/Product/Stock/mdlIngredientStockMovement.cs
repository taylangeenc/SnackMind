using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Place.Warehouse;
using SnackMindModel.Product.Unit;
using SnackMindModel.User.User;

using System;

namespace SnackMindModel.Product.Stock
{
    public class mdlIngredientStockMovement : Entity
    {
        public decimal Quantity { get; set; }
        public DateTime MovementDate { get; set; }

        public Guid IngredientStockRef { get; set; }
        public virtual mdlIngredientStock IngredientStock { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public Guid WarehouseRef { get; set; }
        public virtual mdlWarehouse Warehouse { get; set; }

        public Guid UserRef { get; set; }
        public virtual mdlUser User { get; set; }

        public Guid StockMovementTypeRef { get; set; }
        public virtual mdlStockMovementType StockMovementType { get; set; }

    }
}