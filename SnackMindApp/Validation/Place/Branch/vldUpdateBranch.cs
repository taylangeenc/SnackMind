using FluentValidation;

using SnackMindDTOs.DTOs.Place.Branch;

namespace SnackMindApp.Validation.Place.Branch
{
    public class vldUpdateBranch : AbstractValidator<dtoUpdateBranch>
    {
        public vldUpdateBranch()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Şube adı boş olamaz.")
            .MaximumLength(100).WithMessage("Şube adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir boş olamaz.");

            RuleFor(x => x.Town)
                .NotEmpty().WithMessage("İlçe boş olamaz.");

            RuleFor(x => x.PhoneNumber)
                .MaximumLength(20).WithMessage("Telefon numarası en fazla 20 karakter olabilir.");

            RuleFor(x => x.Email)
                .EmailAddress().When(x => !string.IsNullOrWhiteSpace(x.Email))
                .WithMessage("Geçerli bir e-posta adresi giriniz.");

            RuleFor(x => x.FirmRef)
                .NotEmpty().WithMessage("Firma referansı boş olamaz.");
        }
    }
}