using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Order.Order;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Order.Order;

namespace SnackMindService.Service.Service.Order.Order
{
    public class OrderItemService : SmService<mdlOrderItem>, IOrderItemService
    {
        public OrderItemService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.OrderItem)
        {

        }
    }
}