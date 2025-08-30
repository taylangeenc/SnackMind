using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Printer.PrintState;

namespace SnackMindApp.AppService.IAppService.Setting.Printer
{
    public interface IPrintStateAppService : ISmAppService<dtoCreatePrintState, dtoUpdatePrintState, dtoDetailPrintState, dtoListPrintState>
    {
    }
}