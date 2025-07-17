using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Payment.Payment;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Payment.Payment;

namespace SnackMindService.Service.Service.Payment.Payment
{
    public class PaymentTypeService : SmService<mdlPaymentType>, IPaymentTypeService
    {
        public PaymentTypeService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PaymentType)
        {

        }
    }
}