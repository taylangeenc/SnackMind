using SnackMindCore.Base;
using SnackMindCore.BaseClass;

using SnackMindModel.Payment.Payment;
using SnackMindModel.Place.Branch;
using SnackMindModel.Table.Table;
using SnackMindModel.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Order.Order
{
    public class mdlOrder : Entity
    {
        public string Description { get; set; }
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