using FluentValidation;

using SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient;

namespace SnackMindApp.Validation.Purchase.Purchase.Ingredient
{
    public class vldUpdateIngredientPurchaseOrderItem : AbstractValidator<dtoUpdateIngredientPurchaseOrderItem>
    {
        public vldUpdateIngredientPurchaseOrderItem()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Miktar sıfırdan büyük olmalıdır.");

            RuleFor(x => x.UnitPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Birim fiyat sıfır veya pozitif olmalıdır.");

            RuleFor(x => x.IngredientRef)
                .NotEmpty().WithMessage("Malzeme referansı boş olamaz.");

            RuleFor(x => x.PurchaseOrderRef)
                .NotEmpty().WithMessage("Satın alma siparişi referansı boş olamaz.");
        }
    }
}