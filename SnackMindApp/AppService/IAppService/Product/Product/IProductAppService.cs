using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Product;

namespace SnackMindApp.AppService.IAppService.Product.Product
{
    public interface IProductAppService : ISmAppService<dtoCreateProduct, dtoUpdateProduct, dtoDetailProduct, dtoListProduct>
    {
    }
}