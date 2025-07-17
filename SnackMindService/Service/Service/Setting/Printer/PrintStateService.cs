using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Setting.Printer;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Setting.Printer;

namespace SnackMindService.Service.Service.Setting.Printer
{
    public class PrintStateService : SmService<mdlPrintState>, IPrintStateService
    {
        public PrintStateService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PrintState)
        {
        }
    }
}