using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Payment.Payment;

using SnackMindModel.Payment.Payment;

namespace SnackMindData.Repository.RepositoryBaseClass.Payment.Payment
{
    public class PaymentRepository : SmRepository<mdlPayment>, IPaymentRepository
    {
        public PaymentRepository(SmContext context) : base(context) { }
    }
}