using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Payment.Payment;

using SnackMindModel.Model.Payment.Payment;

namespace SnackMindData.Repository.Repository.Payment.Payment
{
    public class PaymentRepository : SmRepository<mdlPayment>, IPaymentRepository
    {
        public PaymentRepository(SmContext context) : base(context)
        {

        }
    }
}