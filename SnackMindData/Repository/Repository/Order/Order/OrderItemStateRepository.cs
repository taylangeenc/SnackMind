using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Order.Order;

using SnackMindModel.Model.Order.Order;

namespace SnackMindData.Repository.Repository.Order.Order
{
    public class OrderItemStateRepository : SmRepository<mdlOrderItemState>, IOrderItemStateRepository
    {
        public OrderItemStateRepository(SmContext context) : base(context)
        {
            
        }
    }
}