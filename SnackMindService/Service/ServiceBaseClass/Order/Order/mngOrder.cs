using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Order.Order;

using SnackMindService.Service.ServiceBase.Order.Order;

namespace SnackMindService.Service.ServiceBaseClass.Order.Order
{
    public class mngOrder : SmService<mdlOrder>, IOrderService
    {
        protected mngOrder(IUnitOfWork unitOfWork, ISmRepository<mdlOrder> repository) : base(unitOfWork, repository)
        {
        }
    }
}