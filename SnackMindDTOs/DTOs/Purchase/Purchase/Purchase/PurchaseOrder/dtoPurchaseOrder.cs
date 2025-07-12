using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder
{
    public class dtoPurchaseOrder
    {
        public Guid Ref { get; set; }
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }

        public Guid SupplierRef { get; set; }
        public Guid PurchaseOrderStateRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}