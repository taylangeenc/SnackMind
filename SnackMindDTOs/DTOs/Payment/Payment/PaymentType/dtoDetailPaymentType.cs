using SnackMindDTOs.DTOs.Payment.Payment.Payment;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Payment.Payment.PaymentType
{
    public class dtoDetailPaymentType : dtoPaymentType
    {
        public List<dtoPayment> Payments { get; set; }
    }
}