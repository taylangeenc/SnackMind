using FluentValidation;

using SnackMindDTOs.DTOs.Purchase.Supplier;

namespace SnackMindApp.Validation.Purchase.Supplier
{
    public class vldCreateSupplier : AbstractValidator<dtoCreateSupplier>
    {
        public vldCreateSupplier()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Tedarikçi adı boş olamaz.")
                .MaximumLength(150).WithMessage("Tedarikçi adı en fazla 150 karakter olabilir.");

            RuleFor(x => x.PhoneNumber)
                .MaximumLength(20).WithMessage("Telefon numarası en fazla 20 karakter olabilir.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.Address)
                .MaximumLength(500).WithMessage("Adres en fazla 500 karakter olabilir.");
        }
    }
}