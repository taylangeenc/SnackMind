using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Table.Table;

using SnackMindService.Service.ServiceBase.Table.Table;

namespace SnackMindService.Service.ServiceBaseClass.Table.Table
{
    public class mngTable : SmService<mdlTable>, ITableService
    {
        protected mngTable(IUnitOfWork unitOfWork, ISmRepository<mdlTable> repository) : base(unitOfWork, repository)
        {
        }
    }
}