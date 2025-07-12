using FluentValidation;

using SnackMindDTOs.DTOs.Product.Ingredient;

using System;

namespace SnackMindApp.Validation.Product.Ingredient
{
    public class vldUpdateIngredient : AbstractValidator<dtoUpdateIngredient>
    {
        public vldUpdateIngredient()
        {
            RuleFor(x => x.Ref)
                .NotEmpty().WithMessage("Ref değeri boş olamaz.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Malzeme adı boş olamaz.")
                .MaximumLength(100).WithMessage("Malzeme adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.CostPerUnit)
                .GreaterThanOrEqualTo(0).WithMessage("Birim maliyet negatif olamaz.");

            RuleFor(x => x.MinStockLevel)
                .GreaterThanOrEqualTo(0).WithMessage("Minimum stok seviyesi negatif olamaz.");

            RuleFor(x => x.MaxStockLevel)
                .GreaterThanOrEqualTo(0).WithMessage("Maksimum stok seviyesi negatif olamaz.");

            RuleFor(x => x)
                .Must(x => x.MaxStockLevel >= x.MinStockLevel)
                .WithMessage("Maksimum stok, minimum stoktan küçük olamaz.");

            RuleFor(x => x.PurchasePrice)
                .GreaterThanOrEqualTo(0).WithMessage("Satın alma fiyatı negatif olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");

            RuleFor(x => x.ExpirationDate)
                .GreaterThan(DateTime.UtcNow).When(x => x.IsPerishable && x.ExpirationDate.HasValue)
                .WithMessage("Son kullanma tarihi geçerli bir tarih olmalıdır.");
        }
    }
}