using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Table.Table.TableState;

namespace SnackMindApp.AppService.IAppService.Table.Table
{
    public interface ITableStateAppService : ISmAppService<dtoCreateTableState, dtoUpdateTableState, dtoDetailTableState, dtoListTableState>
    {
    }
}