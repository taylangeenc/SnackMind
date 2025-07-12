using SnackMindDTOs.DTOs.Order.OrderItem;
using SnackMindDTOs.DTOs.Product.Recipe.Recipe;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;
using SnackMindDTOs.DTOs.Product.Variant;
using SnackMindDTOs.DTOs.Purchase.Purchase.Product;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Product
{
    public class dtoDetailProduct : dtoProduct
    {
        public string CategoryName { get; set; }
        public string UnitName { get; set; }

        public List<dtoProductVariant> ProductVariants { get; set; }
        public List<dtoRecipe> Recipes { get; set; }
        public List<dtoOrderItem> OrderItems { get; set; }
        public List<dtoProductStock> ProductStocks { get; set; }
        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
        public List<dtoProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
    }
}