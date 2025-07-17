using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Table.Table;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Table.Table;

namespace SnackMindService.Service.Service.Table.Table
{
    public class TableService : SmService<mdlTable>, ITableService
    {
        public TableService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Table)
        {
        }
    }
}