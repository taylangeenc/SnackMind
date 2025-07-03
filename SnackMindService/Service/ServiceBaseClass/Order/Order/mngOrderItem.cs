using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Order.Order;

using SnackMindService.Service.ServiceBase.Order.Order;

namespace SnackMindService.Service.ServiceBaseClass.Order.Order
{
    public class mngOrderItem : SmService<mdlOrderItem>, IOrderItemService
    {
        protected mngOrderItem(IUnitOfWork unitOfWork, ISmRepository<mdlOrderItem> repository) : base(unitOfWork, repository)
        {
        }
    }
}