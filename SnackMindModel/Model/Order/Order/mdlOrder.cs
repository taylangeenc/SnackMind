using SnackMindCore.BaseClass;

using SnackMindModel.Model.Payment.Payment;
using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Table.Table;
using SnackMindModel.Model.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Order.Order
{
    public class mdlOrder : Entity
    {
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public Guid TableRef { get; set; }
        public virtual mdlTable Table { get; set; }

        public Guid UserRef { get; set; }
        public virtual mdlUser User { get; set; }

        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
        public virtual ICollection<mdlPayment> Payments { get; set; }
    }
}