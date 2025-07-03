using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Payment.Payment;

using SnackMindService.Service.ServiceBase.Payment.Payment;

namespace SnackMindService.Service.ServiceBaseClass.Payment.Payment
{
    public class mngPayment : SmService<mdlPayment>, IPaymentService
    {
        protected mngPayment(IUnitOfWork unitOfWork, ISmRepository<mdlPayment> repository) : base(unitOfWork, repository)
        {
        }
    }
}