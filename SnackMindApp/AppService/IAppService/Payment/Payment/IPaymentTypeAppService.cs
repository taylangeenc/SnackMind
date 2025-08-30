using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Payment.Payment.PaymentType;

namespace SnackMindApp.AppService.IAppService.Payment.Payment
{
    public interface IPaymentTypeAppService : ISmAppService<dtoCreatePaymentType, dtoUpdatePaymentType, dtoDetailPaymentType, dtoListPaymentType>
    {
    }
}