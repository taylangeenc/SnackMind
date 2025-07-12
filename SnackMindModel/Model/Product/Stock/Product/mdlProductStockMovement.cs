using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Warehouse;
using SnackMindModel.Model.Product.Unit;
using SnackMindModel.Model.User.User;

using System;

namespace SnackMindModel.Model.Product.Stock.Product
{
    public class mdlProductStockMovement : Entity
    {
        public decimal Quantity { get; set; }
        public DateTime MovementDate { get; set; }

        public Guid ProductStockRef { get; set; }
        public virtual mdlProductStock ProductStock { get; set; }

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