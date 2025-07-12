using System;

namespace SnackMindDTOs.DTOs.Payment.Payment.Payment
{
    public class dtoUpdatePayment
    {
        public Guid Ref { get; set; }
        public string TransactionCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Guid OrderRef { get; set; }
        public Guid? CashShiftRef { get; set; }
        public Guid PaymentTypeRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}