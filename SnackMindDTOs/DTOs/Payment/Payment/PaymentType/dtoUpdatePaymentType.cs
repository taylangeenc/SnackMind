using System;

namespace SnackMindDTOs.DTOs.Payment.Payment.PaymentType
{
    public class dtoUpdatePaymentType
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}