using FluentValidation;

using SnackMindDTOs.DTOs.User.CashShift;

using System;

namespace SnackMindApp.Validation.User.CashShift
{
    public class vldCreateCashShift : AbstractValidator<dtoCreateCashShift>
    {
        public vldCreateCashShift()
        {
            RuleFor(x => x.OpeningCash)
                .GreaterThanOrEqualTo(0).WithMessage("Açılış tutarı negatif olamaz.");

            RuleFor(x => x.OpenedDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Açılış tarihi ileri bir tarih olamaz.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");
        }
    }
}