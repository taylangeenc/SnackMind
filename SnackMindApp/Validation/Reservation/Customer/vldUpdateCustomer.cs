using FluentValidation;

using SnackMindDTOs.DTOs.Reservation.Customer;

namespace SnackMindApp.Validation.Reservation.Customer
{
    public class vldUpdateCustomer : AbstractValidator<dtoUpdateCustomer>
    {
        public vldUpdateCustomer()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Müşteri adı boş olamaz.")
                .MaximumLength(150).WithMessage("Müşteri adı en fazla 150 karakter olabilir.");

            RuleFor(x => x.PhoneNumber)
                .MaximumLength(20).WithMessage("Telefon numarası en fazla 20 karakter olabilir.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.")
                .When(x => !string.IsNullOrEmpty(x.Email));
        }
    }
}