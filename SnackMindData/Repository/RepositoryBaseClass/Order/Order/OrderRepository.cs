using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Order.Order;

using SnackMindModel.Order.Order;

namespace SnackMindData.Repository.RepositoryBaseClass.Order.Order
{
    public class OrderRepository : SmRepository<mdlOrder>, IOrderRepository
    {
        public OrderRepository(SmContext context) : base(context) { }
    }
}