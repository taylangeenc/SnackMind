using FluentValidation;

using SnackMindDTOs.DTOs.Table.Table.Table;

namespace SnackMindApp.Validation.Table.Table
{
    public class vldUpdateTable : AbstractValidator<dtoUpdateTable>
    {
        public vldUpdateTable()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Masa adı boş olamaz.")
                .MaximumLength(100).WithMessage("Masa adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Masa kodu boş olamaz.")
                .MaximumLength(50).WithMessage("Masa kodu en fazla 50 karakter olabilir.");

            RuleFor(x => x.Capacity)
                .GreaterThan(0).WithMessage("Kapasite sıfırdan büyük olmalıdır.");

            RuleFor(x => x.ZoneRef)
                .NotEmpty().WithMessage("Alan (Zone) referansı boş olamaz.");

            RuleFor(x => x.TableStateRef)
                .NotEmpty().WithMessage("Masa durumu referansı boş olamaz.");
        }
    }
}