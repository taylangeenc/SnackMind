using FluentValidation;

using SnackMindDTOs.DTOs.User.User;

namespace SnackMindApp.Validation.User.User
{
    public class vldCreateUser : AbstractValidator<dtoCreateUser>
    {
        public vldCreateUser()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
                .MaximumLength(100).WithMessage("Kullanıcı adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.LoginName)
                .NotEmpty().WithMessage("Giriş adı boş olamaz.")
                .MaximumLength(50).WithMessage("Giriş adı en fazla 50 karakter olabilir.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre boş olamaz.")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş olamaz.")
                .EmailAddress().WithMessage("Geçerli bir email adresi girilmelidir.");

            RuleFor(x => x.BranchRef)
                .NotEmpty().WithMessage("Şube referansı boş olamaz.");

            RuleFor(x => x.RoleRef)
                .NotEmpty().WithMessage("Rol referansı boş olamaz.");
        }
    }
}