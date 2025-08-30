using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStock;

namespace SnackMindApp.AppService.IAppService.Product.Stock.Product
{
    public interface IProductStockAppService : ISmAppService<dtoCreateProductStock, dtoUpdateProductStock, dtoDetailProductStock, dtoListProductStock>
    {
    }
}