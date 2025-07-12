using System;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrderState
{
    public class dtoPurchaseOrderState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}