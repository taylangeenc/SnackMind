using System;

namespace SnackMindDTOs.DTOs.Payment.Payment.Payment
{
    public class dtoListPayment : dtoPayment
    {
        public string PaymentTypeName { get; set; }
        public string OrderCode { get; set; }
        public DateTime? CashShiftOpenedDate { get; set; }
    }
}