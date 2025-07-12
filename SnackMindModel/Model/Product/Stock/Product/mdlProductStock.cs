using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Warehouse;
using SnackMindModel.Model.Product.Product;
using SnackMindModel.Model.Product.Unit;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Stock.Product
{
    public class mdlProductStock : Entity
    {
        public decimal Quantity { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public Guid UnitRef { get; set; }
        public virtual mdlUnit Unit { get; set; }

        public Guid WarehouseRef { get; set; }
        public virtual mdlWarehouse Warehouse { get; set; }

        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
    }
}