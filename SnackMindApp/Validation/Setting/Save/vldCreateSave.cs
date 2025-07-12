using FluentValidation;

using SnackMindDTOs.DTOs.Setting.Save.Save;

using System;

namespace SnackMindApp.Validation.Setting.Save
{
    public class vldCreateSave : AbstractValidator<dtoCreateSave>
    {
        public vldCreateSave()
        {
            RuleFor(x => x.Action)
                .NotEmpty().WithMessage("İşlem (Action) bilgisi boş olamaz.")
                .MaximumLength(100).WithMessage("İşlem (Action) bilgisi en fazla 100 karakter olabilir.");

            RuleFor(x => x.Detail)
                .MaximumLength(1000).WithMessage("Detay bilgisi en fazla 1000 karakter olabilir.");

            RuleFor(x => x.LoggedDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Log tarihi ileri bir tarih olamaz.");

            RuleFor(x => x.FirmRef)
                .NotEmpty().WithMessage("Firma referansı boş olamaz.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");

            RuleFor(x => x.SaveTypeRef)
                .NotEmpty().WithMessage("Kayıt türü referansı boş olamaz.");
        }
    }
}