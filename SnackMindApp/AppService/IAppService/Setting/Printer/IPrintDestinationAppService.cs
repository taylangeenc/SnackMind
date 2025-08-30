using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Printer.PrintDestination;

namespace SnackMindApp.AppService.IAppService.Setting.Printer
{
    public interface IPrintDestinationAppService : ISmAppService<dtoCreatePrintDestination, dtoUpdatePrintDestination, dtoDetailPrintDestination, dtoListPrintDestination>
    {
    }
}