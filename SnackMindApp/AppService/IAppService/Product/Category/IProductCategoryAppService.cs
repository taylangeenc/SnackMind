using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Category.ProductCategory;

namespace SnackMindApp.AppService.IAppService.Product.Category
{
    public interface IProductCategoryAppService : ISmAppService<dtoCreateProductCategory, dtoUpdateProductCategory, dtoDetailProductCategory, dtoListProductCategory>
    {
    }
}