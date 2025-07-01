using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Order.Order;

using SnackMindModel.Order.Order;

namespace SnackMindData.Repository.RepositoryBaseClass.Order.Order
{
    public class OrderItemRepository : SmRepository<mdlOrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(SmContext context) : base(context) { }
    }
}