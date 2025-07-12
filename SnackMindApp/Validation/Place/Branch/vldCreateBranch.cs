using FluentValidation;

using SnackMindDTOs.DTOs.Place.Branch;

namespace SnackMindApp.Validation.Place.Branch
{
    public class vldCreateBranch : AbstractValidator<dtoCreateBranch>
    {
        public vldCreateBranch()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Şube adı boş olamaz.")
                .MaximumLength(100).WithMessage("Şube adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir boş olamaz.");

            RuleFor(x => x.Town)
                .NotEmpty().WithMessage("İlçe boş olamaz.");

            RuleFor(x => x.PhoneNumber)
                .MaximumLength(11).WithMessage("Telefon numarası en fazla 11 karakter olabilir.");

            RuleFor(x => x.Email)
                .EmailAddress().When(x => !string.IsNullOrWhiteSpace(x.Email))
                .WithMessage("Geçerli bir e-posta adresi giriniz.");

            RuleFor(x => x.FirmRef)
                .NotEmpty().WithMessage("Firma referansı boş olamaz.");
        }
    }
}