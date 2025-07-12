using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder
{
    public class dtoCreatePurchaseOrder
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }

        public Guid SupplierRef { get; set; }
        public Guid PurchaseOrderStateRef { get; set; }

        public string Description { get; set; }
    }
}