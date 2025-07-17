using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Reservation.Customer;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Reservation.Customer;

namespace SnackMindService.Service.Service.Reservation.Customer
{
    public class CustomerService : SmService<mdlCustomer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Customer)
        {
        }
    }
}