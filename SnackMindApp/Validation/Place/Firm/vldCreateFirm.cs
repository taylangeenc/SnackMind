using FluentValidation;

using SnackMindDTOs.DTOs.Place.Firm;

namespace SnackMindApp.Validation.Place.Firm
{
    public class vldCreateFirm : AbstractValidator<dtoCreateFirm>
    {
        public vldCreateFirm()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Firma adı boş olamaz.")
                .MaximumLength(100).WithMessage("Firma adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.Address)
                .MaximumLength(500).WithMessage("Adres en fazla 500 karakter olabilir.");

            RuleFor(x => x.ImagePath)
                .MaximumLength(300).WithMessage("Logo yolu en fazla 300 karakter olabilir.")
                .When(x => !string.IsNullOrWhiteSpace(x.ImagePath));
        }
    }
}