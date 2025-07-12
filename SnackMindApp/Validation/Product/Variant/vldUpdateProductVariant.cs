using FluentValidation;

using SnackMindDTOs.DTOs.Product.Variant;

namespace SnackMindApp.Validation.Product.Variant
{
    public class vldUpdateProductVariant : AbstractValidator<dtoUpdateProductVariant>
    {
        public vldUpdateProductVariant()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Varyant adı boş olamaz.")
                .MaximumLength(100).WithMessage("Varyant adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.ExtraPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Ek fiyat sıfır veya pozitif olmalıdır.");

            RuleFor(x => x.ProductRef)
                .NotEmpty().WithMessage("Ürün referansı boş olamaz.");
        }
    }
}