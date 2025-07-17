using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Payment.Payment;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Payment.Payment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnackMindService.Service.Service.Payment.Payment
{
    public class PaymentService : SmService<mdlPayment>, IPaymentService
    {
        public PaymentService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Payment)
        {
            
        }
    }
}