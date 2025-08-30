using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Payment.Payment.Payment;

namespace SnackMindApp.AppService.IAppService.Payment.Payment
{
    public interface IPaymentAppService : ISmAppService<dtoCreatePayment, dtoUpdatePayment, dtoDetailPayment, dtoListPayment>
    {
    }
}