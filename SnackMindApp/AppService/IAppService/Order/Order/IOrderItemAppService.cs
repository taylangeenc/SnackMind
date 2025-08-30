using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Order.OrderItem;

namespace SnackMindApp.AppService.IAppService.Order.Order
{
    public interface IOrderItemAppService : ISmAppService<dtoCreateOrderItem, dtoUpdateOrderItem, dtoDetailOrderItem, dtoListOrderItem>
    {
    }
}