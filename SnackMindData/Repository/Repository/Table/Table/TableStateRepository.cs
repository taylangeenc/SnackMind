using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Table.Table;

using SnackMindModel.Model.Table.Table;

namespace SnackMindData.Repository.Repository.Table.Table
{
    public class TableStateRepository : SmRepository<mdlTableState>, ITableStateRepository
    {
        public TableStateRepository(SmContext context) : base(context)
        {
            
        }
    }
}