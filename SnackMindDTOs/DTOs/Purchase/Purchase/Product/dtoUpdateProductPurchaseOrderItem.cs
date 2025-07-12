using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Product
{
    public class dtoUpdateProductPurchaseOrderItem
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public Guid ProductRef { get; set; }
        public Guid PurchaseOrderRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}