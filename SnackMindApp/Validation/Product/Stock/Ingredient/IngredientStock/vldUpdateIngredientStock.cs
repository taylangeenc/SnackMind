using FluentValidation;

using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;

namespace SnackMindApp.Validation.Product.Stock.Ingredient.IngredientStock
{
    public class vldUpdateIngredientStock : AbstractValidator<dtoUpdateIngredientStock>
    {
        public vldUpdateIngredientStock()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Stok miktarı negatif olamaz.");

            RuleFor(x => x.IngredientRef)
                .NotEmpty().WithMessage("Malzeme referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.WarehouseRef)
                .NotEmpty().WithMessage("Depo referansı boş olamaz.");
        }
    }
}