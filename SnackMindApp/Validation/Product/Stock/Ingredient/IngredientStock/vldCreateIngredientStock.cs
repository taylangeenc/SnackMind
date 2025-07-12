using FluentValidation;

using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStock;

namespace SnackMindApp.Validation.Product.Stock.Ingredient.IngredientStock
{
    public class vldCreateIngredientStock : AbstractValidator<dtoCreateIngredientStock>
    {
        public vldCreateIngredientStock()
        {
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