using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Stock.StockMovementType;

namespace SnackMindApp.AppService.IAppService.Product.Stock
{
    public interface IStockMovementTypeAppService : ISmAppService<dtoCreateStockMovementType, dtoUpdateStockMovementType, dtoDetailStockMovementType, dtoListStockMovementType>
    {
    }
}