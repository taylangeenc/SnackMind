using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Order.Order;

using SnackMindModel.Model.Order.Order;

namespace SnackMindData.Repository.Repository.Order.Order
{
    public class OrderRepository : SmRepository<mdlOrder>, IOrderRepository
    {
        public OrderRepository(SmContext context) : base(context)
        {
            
        }
    }
}