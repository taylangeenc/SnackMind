using SnackMindCore.BaseClass;

using SnackMindModel.Model.Payment.Payment;
using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.User.CashShift
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