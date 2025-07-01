using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Reservation.Customer;

using SnackMindModel.Reservation.Customer;

namespace SnackMindData.Repository.RepositoryBaseClass.Reservation.Customer
{
    public class CustomerRepository : SmRepository<mdlCustomer>, ICustomerRepository
    {
        public CustomerRepository(SmContext context) : base(context) { }
    }
}