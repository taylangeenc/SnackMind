using SnackMindDTOs.DTOs.Product.Product;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Product
{
    public class dtoDetailProductPurchaseOrderItem : dtoProductPurchaseOrderItem
    {
        public string ProductName { get; set; }
        public string PurchaseOrderCode { get; set; }

        public dtoProduct Product { get; set; }
    }
}