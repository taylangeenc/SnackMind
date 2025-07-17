using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Table.Table;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Table.Table;

namespace SnackMindService.Service.Service.Table.Table
{
    public class TableStateService : SmService<mdlTableState>, ITableStateService
    {
        public TableStateService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.TableState)
        {
        }
    }
}