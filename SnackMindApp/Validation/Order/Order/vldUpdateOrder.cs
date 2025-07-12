using FluentValidation;

using SnackMindDTOs.DTOs.Order.Order;

using System;

namespace SnackMindApp.Validation.Order.Order
{
    public class vldUpdateOrder : AbstractValidator<dtoUpdateOrder>
    {
        public vldUpdateOrder()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.TableRef)
                .NotEmpty().WithMessage("Masa referansı boş olamaz.");

            RuleFor(x => x.UserRef)
                .NotEmpty().WithMessage("Kullanıcı referansı boş olamaz.");

            RuleFor(x => x.OpenedDate)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Açılış tarihi ileri bir tarih olamaz.");

            RuleFor(x => x.ClosedDate)
                .GreaterThan(x => x.OpenedDate).When(x => x.ClosedDate.HasValue)
                .WithMessage("Kapanış tarihi, açılış tarihinden sonra olmalıdır.");

            RuleFor(x => x.OrderItems)
                .NotNull().WithMessage("Sipariş ürünleri boş olamaz.")
                .Must(x => x.Count > 0).WithMessage("En az bir sipariş ürünü olmalıdır.");
        }
    }
}