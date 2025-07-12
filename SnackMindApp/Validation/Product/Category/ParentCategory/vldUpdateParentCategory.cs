using FluentValidation;

using SnackMindDTOs.DTOs.Product.Category.ParentCategory;

namespace SnackMindApp.Validation.Product.Category.ParentCategory
{
    public class vldUpdateParentCategory : AbstractValidator<dtoUpdateParentCategory>
    {
        public vldUpdateParentCategory()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Üst kategori adı boş olamaz.")
                .MaximumLength(100).WithMessage("Üst kategori adı en fazla 100 karakter olabilir.");
        }
    }
}