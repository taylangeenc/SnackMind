using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Table.Table;

using SnackMindModel.Table.Table;

namespace SnackMindData.Repository.RepositoryBaseClass.Table.Table
{
    public class TableRepository : SmRepository<mdlTable>, ITableRepository
    {
        public TableRepository(SmContext context) : base(context) { }
    }
}