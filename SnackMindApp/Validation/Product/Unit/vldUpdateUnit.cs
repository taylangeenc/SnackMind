using FluentValidation;

using SnackMindDTOs.DTOs.Product.Unit;

namespace SnackMindApp.Validation.Product.Unit
{
    public class vldUpdateUnit : AbstractValidator<dtoUnit>
    {
        public vldUpdateUnit()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Birim adı boş olamaz.")
                .MaximumLength(50).WithMessage("Birim adı en fazla 50 karakter olabilir.");

            RuleFor(x => x.Abbreviation)
                .NotEmpty().WithMessage("Kısaltma boş olamaz.")
                .MaximumLength(5).WithMessage("Kısaltma en fazla 5 karakter olabilir.");

            RuleFor(x => x.IsDefault)
                .NotNull().WithMessage("Varsayılan alanı belirtilmelidir.");
        }
    }
}