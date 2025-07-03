using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Reservation.Customer;

using SnackMindService.Service.ServiceBase.Reservation.Customer;

namespace SnackMindService.Service.ServiceBaseClass.Reservation.Customer
{
    public class mngCustomer : SmService<mdlCustomer>, ICustomerService
    {
        protected mngCustomer(IUnitOfWork unitOfWork, ISmRepository<mdlCustomer> repository) : base(unitOfWork, repository)
        {
        }
    }
}