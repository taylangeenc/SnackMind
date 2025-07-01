using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.User.CashShift;

using SnackMindModel.User.CashShift;

namespace SnackMindData.Repository.RepositoryBaseClass.User.CashShift
{
    public class CashShiftRepository : SmRepository<mdlCashShift>, ICashShiftRepository
    {
        public CashShiftRepository(SmContext context) : base(context) { }
    }
}