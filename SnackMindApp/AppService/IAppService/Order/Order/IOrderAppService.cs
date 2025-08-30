using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Order.Order;

namespace SnackMindApp.AppService.IAppService.Order.Order
{
    public interface IOrderAppService : ISmAppService<dtoCreateOrder, dtoUpdateOrder, dtoDetailOrder, dtoListOrder>
    {
        
    }
}