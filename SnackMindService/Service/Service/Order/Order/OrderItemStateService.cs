using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Order.Order;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Order.Order;

namespace SnackMindService.Service.Service.Order.Order
{
    public class OrderItemStateService : SmService<mdlOrderItemState>, IOrderItemState
    {
        public OrderItemStateService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.OrderItemState)
        {
            
        }
    }
}