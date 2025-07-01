using SnackMindCore.BaseClass;

using SnackMindModel.Purchase.Purchase;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Purchase.Supplier
{
    public class mdlSupplier : EntityCard
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<mdlPurchaseOrder> PurchaseOrders { get; set; }
    }
}