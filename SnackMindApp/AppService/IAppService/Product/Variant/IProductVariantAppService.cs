using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Variant;

namespace SnackMindApp.AppService.IAppService.Product.Variant
{
    public interface IProductVariantAppService : ISmAppService<dtoCreateProductVariant, dtoUpdateProductVariant, dtoDetailProductVariant, dtoListProductVariant>
    {
    }
}