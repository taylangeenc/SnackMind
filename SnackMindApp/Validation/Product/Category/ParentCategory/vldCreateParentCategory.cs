using FluentValidation;

using SnackMindDTOs.DTOs.Product.Category.ParentCategory;

namespace SnackMindApp.Validation.Product.Category.ParentCategory
{
    public class vldCreateParentCategory : AbstractValidator<dtoCreateParentCategory>
    {
        public vldCreateParentCategory()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Üst kategori adı boş olamaz.")
                .MaximumLength(100).WithMessage("Üst kategori adı en fazla 100 karakter olabilir.");
        }
    }
}