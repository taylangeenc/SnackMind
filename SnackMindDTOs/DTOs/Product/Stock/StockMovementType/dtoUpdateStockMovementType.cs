using System;

namespace SnackMindDTOs.DTOs.Product.Stock.StockMovementType
{
    public class dtoUpdateStockMovementType
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}