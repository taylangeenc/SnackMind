using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;

namespace SnackMindApp.AppService.IAppService.Product.Stock.Product
{
    public interface IProductStockMovementAppService : ISmAppService<dtoCreateProductStockMovement, dtoUpdateProductStockMovement, dtoDetailProductStockMovement, dtoListProductStockMovement>
    {
    }
}