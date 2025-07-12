namespace SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement
{
    public class dtoListProductStockMovement : dtoProductStockMovement
    {
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }
        public string UserName { get; set; }
        public string StockMovementTypeName { get; set; }
    }
}