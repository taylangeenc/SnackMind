using FluentValidation;

using SnackMindDTOs.DTOs.Purchase.Purchase.Product;

namespace SnackMindApp.Validation.Purchase.Purchase.Product
{
    public class vldUpdateProductPurchaseOrderItem : AbstractValidator<dtoUpdateProductPurchaseOrderItem>
    {
        public vldUpdateProductPurchaseOrderItem()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Miktar sıfırdan büyük olmalıdır.");

            RuleFor(x => x.UnitPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Birim fiyat sıfır veya pozitif olmalıdır.");

            RuleFor(x => x.ProductRef)
                .NotEmpty().WithMessage("Ürün referansı boş olamaz.");

            RuleFor(x => x.PurchaseOrderRef)
                .NotEmpty().WithMessage("Satın alma siparişi referansı boş olamaz.");
        }
    }
}