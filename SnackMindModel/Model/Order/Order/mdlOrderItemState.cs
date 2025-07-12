using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Order.Order
{
    public class mdlOrderItemState : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
    }
}