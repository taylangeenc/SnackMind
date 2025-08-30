using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Printer.PrinterConnectionType;

namespace SnackMindApp.AppService.IAppService.Setting.Printer
{
    public interface IPrinterConnectionTypeAppService : ISmAppService<dtoCreatePrinterConnectionType, dtoUpdatePrinterConnectionType, dtoDetailPrinterConnectionType, dtoListPrinterConnectionType>
    {
    }
}