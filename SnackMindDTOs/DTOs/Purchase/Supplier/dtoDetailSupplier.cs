using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Purchase.Supplier
{
    public class dtoDetailSupplier : dtoSupplier
    {
        public List<dtoPurchaseOrder> PurchaseOrders { get; set; }
    }
}