using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Reservation.Customer;

namespace SnackMindApp.AppService.IAppService.Reservation.Customer
{
    public interface ICustomerAppService : ISmAppService<dtoCreateCustomer, dtoUpdateCustomer, dtoDetailCustomer, dtoListCustomer>
    {
    }
}