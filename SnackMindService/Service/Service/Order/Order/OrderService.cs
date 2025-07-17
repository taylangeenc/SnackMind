using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Order.Order;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Order.Order;

namespace SnackMindService.Service.Service.Order.Order
{
    public class OrderService : SmService<mdlOrder>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Order)
        {

        }
    }
}