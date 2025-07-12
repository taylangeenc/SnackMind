using FluentValidation;

using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;

namespace SnackMindApp.Validation.Product.Stock.Ingredient.IngredientStockMovement
{
    public class vldCreateIngredientStockMovement : AbstractValidator<dtoCreateIngredientStockMovement>
    {
        public vldCreateIngredientStockMovement()
        {
            RuleFor(x => x.Quantity)
                .NotEqual(0).WithMessage("Hareket miktarı sıfır olamaz.");

            RuleFor(x => x.MovementDate)
                .NotEmpty().WithMessage("Hareket tarihi boş olamaz.");

            RuleFor(x => x.IngredientStockRef)
                .NotEmpty().WithMessage("Malzeme stok referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.WarehouseRef)
                .NotEmpty().WithMessage("Depo referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");

            RuleFor(x => x.StockMovementTypeRef)
                .NotEmpty().WithMessage("Stok hareket tipi referansı boş olamaz.");
        }
    }
}