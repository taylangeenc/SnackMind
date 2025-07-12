using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Purchase.Purchase.Purchase
{
    public class mdlPurchaseOrderState : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlPurchaseOrder> PurchaseOrders { get; set; }
    }
}