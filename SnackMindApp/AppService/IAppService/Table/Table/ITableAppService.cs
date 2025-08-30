using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Table.Table.Table;

namespace SnackMindApp.AppService.IAppService.Table.Table
{
    public interface ITableAppService : ISmAppService<dtoCreateTable, dtoUpdateTable, dtoDetailTable, dtoListTable>
    {
    }
}