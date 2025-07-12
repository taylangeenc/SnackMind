using FluentValidation;

using SnackMindDTOs.DTOs.User.Role;

using System.Text.Json;

namespace SnackMindApp.Validation.User.Role
{
    public class vldCreateRole : AbstractValidator<dtoCreateRole>
    {
        public vldCreateRole()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Rol adı boş olamaz.")
                .MaximumLength(100).WithMessage("Rol adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.Permission)
                .NotEmpty().WithMessage("Yetki bilgisi (Permission) boş olamaz.")
                .Must(BeValidJson).WithMessage("Yetki bilgisi geçerli bir JSON formatında olmalıdır.");
        }
        private bool BeValidJson(string json)
        {
            try
            {
                var obj = JsonDocument.Parse(json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}