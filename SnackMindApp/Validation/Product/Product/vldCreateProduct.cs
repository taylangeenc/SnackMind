using FluentValidation;

using SnackMindDTOs.DTOs.Product.Product;

namespace SnackMindApp.Validation.Product.Product
{
    public class vldCreateProduct : AbstractValidator<dtoCreateProduct>
    {
        public vldCreateProduct()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(100).WithMessage("Ürün adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.StockCode)
                .MaximumLength(50).WithMessage("Stok kodu en fazla 50 karakter olabilir.");

            RuleFor(x => x.ImagePath)
                .MaximumLength(300).WithMessage("Resim yolu en fazla 300 karakter olabilir.")
                .When(x => !string.IsNullOrWhiteSpace(x.ImagePath));

            RuleFor(x => x.Barcode)
                .MaximumLength(50).WithMessage("Barkod en fazla 50 karakter olabilir.");

            RuleFor(x => x.SalesPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı negatif olamaz.");

            RuleFor(x => x.CostPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Maliyet fiyatı negatif olamaz.");

            RuleFor(x => x.TaxRate)
                .InclusiveBetween(0, 100).WithMessage("Vergi oranı 0 ile 100 arasında olmalıdır.");

            RuleFor(x => x.CategoryRef)
                .NotEmpty().WithMessage("Kategori referansı boş olamaz.");

            RuleFor(x => x.UnitRef)
                .NotEmpty().WithMessage("Birim referansı boş olamaz.");
        }
    }
}