using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Place.Warehouse;

namespace SnackMindApp.AppService.IAppService.Place.Warehouse
{
    public interface IWarehouseAppService : ISmAppService<dtoCreateWarehouse, dtoUpdateWarehouse, dtoDetailWarehouse, dtoListWarehouse>
    {
    }
}