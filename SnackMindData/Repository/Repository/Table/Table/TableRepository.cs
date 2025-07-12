using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Table.Table;

using SnackMindModel.Model.Table.Table;

namespace SnackMindData.Repository.Repository.Table.Table
{
    public class TableRepository : SmRepository<mdlTable>, ITableRepository
    {
        public TableRepository(SmContext context) : base(context)
        {
            
        }
    }
}