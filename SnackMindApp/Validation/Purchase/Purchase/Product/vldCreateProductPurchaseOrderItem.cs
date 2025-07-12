using FluentValidation;

using SnackMindDTOs.DTOs.Purchase.Purchase.Product;

namespace SnackMindApp.Validation.Purchase.Purchase.Product
{
    public class vldCreateProductPurchaseOrderItem : AbstractValidator<dtoCreateProductPurchaseOrderItem>
    {
        public vldCreateProductPurchaseOrderItem()
        {
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