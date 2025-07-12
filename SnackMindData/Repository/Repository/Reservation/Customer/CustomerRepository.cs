using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Reservation.Customer;

using SnackMindModel.Model.Reservation.Customer;

namespace SnackMindData.Repository.Repository.Reservation.Customer
{
    public class CustomerRepository : SmRepository<mdlCustomer>, ICustomerRepository
    {
        public CustomerRepository(SmContext context) : base(context)
        {
            
        }
    }
}