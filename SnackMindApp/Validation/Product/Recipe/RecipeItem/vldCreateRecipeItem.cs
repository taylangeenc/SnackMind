using FluentValidation;

using SnackMindDTOs.DTOs.Product.Recipe.RecipeItem;

namespace SnackMindApp.Validation.Product.Recipe.RecipeItem
{
    public class vldCreateRecipeItem : AbstractValidator<dtoUpdateRecipeItem>
    {
        public vldCreateRecipeItem()
        {
            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Miktar sıfırdan büyük olmalıdır.");

            RuleFor(x => x.IngredientRef)
                .NotEmpty().WithMessage("Malzeme referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.RecipeRef)
                .NotEmpty().WithMessage("Reçete referansı boş olamaz.");
        }
    }
}