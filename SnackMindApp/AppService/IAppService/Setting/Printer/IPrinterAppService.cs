using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Printer.Printer;

namespace SnackMindApp.AppService.IAppService.Setting.Printer
{
    public interface IPrinterAppService : ISmAppService<dtoCreatePrinter, dtoUpdatePrinter, dtoDetailPrinter, dtoListPrinter>
    {
    }
}