using System;

namespace SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock
{
    public class dtoUpdateProductStock
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }

        public Guid ProductRef { get; set; }
        public Guid UnitRef { get; set; }
        public Guid WarehouseRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}