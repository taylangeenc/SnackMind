using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Setting.Printer;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Setting.Printer;

namespace SnackMindService.Service.Service.Setting.Printer
{
    public class PrinterService : SmService<mdlPrinter>, IPrinterService
    {
        public PrinterService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Printer)
        {
        }
    }
}