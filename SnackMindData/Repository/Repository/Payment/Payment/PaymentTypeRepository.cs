using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Payment.Payment;

using SnackMindModel.Model.Payment.Payment;

namespace SnackMindData.Repository.Repository.Payment.Payment
{
    public class PaymentTypeRepository : SmRepository<mdlPaymentType>, IPaymentTypeRepository
    {
        public PaymentTypeRepository(SmContext context) : base(context)
        {
            
        }
    }
}