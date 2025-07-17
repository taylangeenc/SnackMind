using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Setting.Printer;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Setting.Printer;

namespace SnackMindService.Service.Service.Setting.Printer
{
    public class PrintDestinationService : SmService<mdlPrintDestination>, IPrintDestinationService
    {
        public PrintDestinationService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PrintDestination)
        {
        }
    }
}