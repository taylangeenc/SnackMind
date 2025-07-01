using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Order.Order;
using SnackMindModel.User.CashShift;

using System;

namespace SnackMindModel.Payment.Payment
{
    public class mdlPayment : Entity
    {
        public string Description { get; set; }
        public string TransactionCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Guid OrderRef { get; set; }
        public virtual mdlOrder Order { get; set; }

        public Guid? CashShiftRef { get; set; }
        public virtual mdlCashShift CashShift { get; set; }

        public Guid PaymentTypeRef { get; set; }
        public virtual mdlPaymentType PaymentType { get; set; }
    }
}