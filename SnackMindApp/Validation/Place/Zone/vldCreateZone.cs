using FluentValidation;

using SnackMindDTOs.DTOs.Place.Zone;

namespace SnackMindApp.Validation.Place.Zone
{
    public class vldCreateZone : AbstractValidator<dtoCreateZone>
    {
        public vldCreateZone()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Bölge adı boş olamaz.")
                .MaximumLength(100).WithMessage("Bölge adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");
        }
    }
}