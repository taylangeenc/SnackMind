using FluentValidation;

using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

namespace SnackMindApp.Validation.Product.Stock.Product.ProductStockMovement
{
    public class vldUpdateProductStockMovement : AbstractValidator<dtoUpdateProductStockMovement>
    {
        public vldUpdateProductStockMovement()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Quantity)
                .NotEqual(0).WithMessage("Hareket miktarı sıfır olamaz.");

            RuleFor(x => x.MovementDate)
                .NotEmpty().WithMessage("Hareket tarihi boş olamaz.");

            RuleFor(x => x.ProductStockRef)
                .NotEmpty().WithMessage("Ürün stok referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.WarehouseRef)
                .NotEmpty().WithMessage("Depo referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");

            RuleFor(x => x.StockMovementTypeRef)
                .NotEmpty().WithMessage("Hareket tipi referansı boş olamaz.");
        }
    }
}