using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Order.OrderItemState;

namespace SnackMindApp.AppService.IAppService.Order.Order
{
    public interface IOrderItemStateAppService : ISmAppService<dtoCreateOrderItemState, dtoUpdateOrderItemState, dtoDetailOrderItemState, dtoListOrderItemState>
    {
    }
}