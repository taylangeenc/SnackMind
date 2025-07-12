using SnackMindCore.BaseClass;

using SnackMindModel.Model.Purchase.Purchase.Purchase;

using System.Collections.Generic;

namespace SnackMindModel.Model.Purchase.Supplier
{
    public class mdlSupplier : Entity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<mdlPurchaseOrder> PurchaseOrders { get; set; }
    }
}