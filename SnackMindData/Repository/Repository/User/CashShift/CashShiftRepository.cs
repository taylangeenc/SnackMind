using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.User.CashShift;

using SnackMindModel.Model.User.CashShift;

namespace SnackMindData.Repository.Repository.User.CashShift
{
    public class CashShiftRepository : SmRepository<mdlCashShift>, ICashShiftRepository
    {
        public CashShiftRepository(SmContext context) : base(context)
        {
            
        }
    }
}