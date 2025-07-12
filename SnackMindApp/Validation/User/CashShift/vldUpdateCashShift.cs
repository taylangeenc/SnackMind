using FluentValidation;

using SnackMindDTOs.DTOs.User.CashShift;

using System;

namespace SnackMindApp.Validation.User.CashShift
{
    public class vldUpdateCashShift : AbstractValidator<dtoUpdateCashShift>
    {
        public vldUpdateCashShift()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.OpeningCash)
                .GreaterThanOrEqualTo(0).WithMessage("Açılış tutarı negatif olamaz.");

            RuleFor(x => x.ClosingCash)
                .GreaterThanOrEqualTo(0).When(x => x.ClosingCash.HasValue)
                .WithMessage("Kapanış tutarı negatif olamaz.");

            RuleFor(x => x.OpenedDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Açılış tarihi ileri bir tarih olamaz.");

            RuleFor(x => x.ClosedDate)
                .GreaterThan(x => x.OpenedDate).When(x => x.ClosedDate.HasValue)
                .WithMessage("Kapanış tarihi, açılış tarihinden sonra olmalıdır.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");
        }
    }
}