using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrderState
{
    public class dtoDetailPurchaseOrderState : dtoPurchaseOrderState
    {
        public List<dtoPurchaseOrder> PurchaseOrders { get; set; }
    }
}