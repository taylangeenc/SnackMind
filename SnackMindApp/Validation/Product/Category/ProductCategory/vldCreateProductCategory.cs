using FluentValidation;

using SnackMindDTOs.DTOs.Product.Category.ProductCategory;

namespace SnackMindApp.Validation.Product.Category.ProductCategory
{
    public class vldCreateProductCategory : AbstractValidator<dtoCreateProductCategory>
    {
        public vldCreateProductCategory()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ürün kategorisi adı boş olamaz.")
                .MaximumLength(100).WithMessage("Ürün kategorisi adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.ParentCategoryRef)
                .NotEmpty().WithMessage("Üst kategori referansı boş olamaz.");
        }
    }
}