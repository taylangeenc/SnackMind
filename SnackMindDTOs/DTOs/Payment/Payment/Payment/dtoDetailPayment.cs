using SnackMindDTOs.DTOs.Order.Order;
using SnackMindDTOs.DTOs.Payment.Payment.PaymentType;
using SnackMindDTOs.DTOs.User.CashShift;

using System;

namespace SnackMindDTOs.DTOs.Payment.Payment.Payment
{
    public class dtoDetailPayment : dtoPayment
    {
        public dtoOrder Order { get; set; }
        public dtoCashShift CashShift { get; set; }
        public dtoPaymentType PaymentType { get; set; }

        public string OrderCode { get; set; }
        public DateTime? CashShiftOpenedDate { get; set; }
        public string PaymentTypeName { get; set; }
    }
}