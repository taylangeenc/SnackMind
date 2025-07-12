using FluentValidation;

using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;

namespace SnackMindApp.Validation.Product.Stock.Product.ProductStock
{
    public class vldUpdateProductStock : AbstractValidator<dtoUpdateProductStock>
    {
        public vldUpdateProductStock()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Stok miktarı negatif olamaz.");

            RuleFor(x => x.ProductRef)
                .NotEmpty().WithMessage("Ürün referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.WarehouseRef)
                .NotEmpty().WithMessage("Depo referansı boş olamaz.");
        }
    }
}