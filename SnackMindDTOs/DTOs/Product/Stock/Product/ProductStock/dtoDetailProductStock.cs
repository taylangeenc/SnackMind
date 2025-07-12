using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock
{
    public class dtoDetailProductStock : dtoProductStock
    {
        public string ProductName { get; set; }
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }

        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
    }
}