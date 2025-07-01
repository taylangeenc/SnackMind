using SnackMindCore.BaseClass;

using SnackMindModel.Payment.Payment;
using SnackMindModel.Place.Branch;
using SnackMindModel.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.User.CashShift
{
    public class mdlCashShift : Entity
    {
        public decimal OpeningCash { get; set; }
        public decimal? ClosingCash { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public Guid UserRef { get; set; }
        public virtual mdlUser User { get; set; }

        public virtual ICollection<mdlPayment> Payments { get; set; }
    }
}