using FluentValidation;

using SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder;

using System;

namespace SnackMindApp.Validation.Purchase.Purchase.Purchase
{
    public class vldUpdatePurchaseOrder : AbstractValidator<dtoUpdatePurchaseOrder>
    {
        public vldUpdatePurchaseOrder()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.OrderCode)
                .NotEmpty().WithMessage("Sipariş kodu boş olamaz.")
                .MaximumLength(50).WithMessage("Sipariş kodu en fazla 50 karakter olabilir.");

            RuleFor(x => x.OrderDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Sipariş tarihi gelecekte olamaz.");

            RuleFor(x => x.SupplierRef)
                .NotEmpty().WithMessage("Tedarikçi referansı boş olamaz.");

            RuleFor(x => x.PurchaseOrderStateRef)
                .NotEmpty().WithMessage("Sipariş durumu referansı boş olamaz.");
        }
    }
}