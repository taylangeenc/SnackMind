using FluentValidation;

using SnackMindDTOs.DTOs.Place.Warehouse;

namespace SnackMindApp.Validation.Place.Warehouse
{
    public class vldUpdateWarehouse : AbstractValidator<dtoUpdateWarehouse>
    {
        public vldUpdateWarehouse()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Depo adı boş olamaz.")
                .MaximumLength(100).WithMessage("Depo adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");
        }
    }
}