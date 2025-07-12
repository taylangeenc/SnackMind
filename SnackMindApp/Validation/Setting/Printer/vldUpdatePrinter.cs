using FluentValidation;

using SnackMindDTOs.DTOs.Setting.Printer.Printer;

namespace SnackMindApp.Validation.Setting.Printer
{
    public class vldUpdatePrinter : AbstractValidator<dtoUpdatePrinter>
    {
        public vldUpdatePrinter()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Yazıcı adı boş olamaz.")
                .MaximumLength(100).WithMessage("Yazıcı adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.IPAddress)
                .NotEmpty().WithMessage("IP adresi boş olamaz.")
                .MaximumLength(50).WithMessage("IP adresi en fazla 50 karakter olabilir.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Yazıcı adedi sıfırdan büyük olmalıdır.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.PrintDestinationRef)
                .NotEmpty().WithMessage("Baskı hedefi referansı boş olamaz.");

            RuleFor(x => x.PrintStateRef)
                .NotEmpty().WithMessage("Baskı durumu referansı boş olamaz.");

            RuleFor(x => x.PrinterConnectionTypeRef)
                .NotEmpty().WithMessage("Bağlantı tipi referansı boş olamaz.");
        }
    }
}