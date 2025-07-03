using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.User.CashShift;

using SnackMindService.Service.ServiceBase.User.CashShift;

namespace SnackMindService.Service.ServiceBaseClass.User.CashShift
{
    public class mngCashShift : SmService<mdlCashShift>, ICashShiftService
    {
        protected mngCashShift(IUnitOfWork unitOfWork, ISmRepository<mdlCashShift> repository) : base(unitOfWork, repository)
        {
        }
    }
}