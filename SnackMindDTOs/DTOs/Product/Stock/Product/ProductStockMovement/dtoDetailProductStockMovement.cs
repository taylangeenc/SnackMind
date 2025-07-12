using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;

namespace SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement
{
    public class dtoDetailProductStockMovement : dtoProductStockMovement
    {
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }
        public string UserName { get; set; }
        public string StockMovementTypeName { get; set; }

        public dtoProductStock ProductStock { get; set; }
    }
}