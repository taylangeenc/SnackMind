using FluentValidation;

using SnackMindDTOs.DTOs.Payment.Payment.Payment;

using System;

namespace SnackMindApp.Validation.Payment.Payment
{
    public class vldCreatePayment : AbstractValidator<dtoCreatePayment>
    {
        public vldCreatePayment()
        {
            RuleFor(x => x.TransactionCode)
                .NotEmpty().WithMessage("İşlem kodu boş olamaz.")
                .MaximumLength(100).WithMessage("İşlem kodu en fazla 100 karakter olabilir.");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Tutar sıfırdan büyük olmalıdır.");

            RuleFor(x => x.PaymentDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Ödeme tarihi ileri bir tarih olamaz.");

            RuleFor(x => x.OrderRef)
                .NotEmpty().WithMessage("Sipariş referansı boş olamaz.");

            RuleFor(x => x.PaymentTypeRef)
                .NotEmpty().WithMessage("Ödeme türü referansı boş olamaz.");
        }
    }
}