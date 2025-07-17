using SnackMindData.UnitOfWork;

using SnackMindModel.Model.User.CashShift;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.User.CashShift;

namespace SnackMindService.Service.Service.User.CashShift
{
    public class CashShiftService : SmService<mdlCashShift>, ICashShiftService
    {
        public CashShiftService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.CashShift)
        {
        }
    }
}