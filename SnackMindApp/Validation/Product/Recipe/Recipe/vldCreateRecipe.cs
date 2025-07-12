using FluentValidation;

using SnackMindDTOs.DTOs.Product.Recipe.Recipe;

namespace SnackMindApp.Validation.Product.Recipe.Recipe
{
    public class vldCreateRecipe : AbstractValidator<dtoCreateRecipe>
    {
        public vldCreateRecipe()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Reçete adı boş olamaz.")
                .MaximumLength(100).WithMessage("Reçete adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.ProductRef)
                .NotEmpty().WithMessage("Ürün referansı boş olamaz.");
        }
    }
}