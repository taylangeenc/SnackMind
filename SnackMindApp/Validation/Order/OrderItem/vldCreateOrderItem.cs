using FluentValidation;

using SnackMindDTOs.DTOs.Order.OrderItem;

namespace SnackMindApp.Validation.Order.OrderItem
{
    public class vldCreateOrderItem : AbstractValidator<dtoCreateOrderItem>
    {
        public vldCreateOrderItem()
        {
            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Miktar sıfırdan büyük olmalıdır.");

            RuleFor(x => x.UnitPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Birim fiyatı negatif olamaz.");

            RuleFor(x => x.ProductRef)
                .NotEmpty().WithMessage("Ürün referansı boş olamaz.");

            RuleFor(x => x.ProductVariantRef)
                .NotEmpty().WithMessage("Ürün varyantı referansı boş olamaz.");

            RuleFor(x => x.OrderRef)
                .NotEmpty().WithMessage("Sipariş referansı boş olamaz.");

            RuleFor(x => x.OrderItemStateRef)
                .NotEmpty().WithMessage("Sipariş kalem durumu referansı boş olamaz.");
        }
    }
}