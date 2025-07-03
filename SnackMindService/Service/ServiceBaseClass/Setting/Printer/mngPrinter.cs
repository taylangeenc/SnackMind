using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Setting.Printer;

using SnackMindService.Service.ServiceBase.Setting.Printer;

namespace SnackMindService.Service.ServiceBaseClass.Setting.Printer
{
    public class mngPrinter : SmService<mdlPrinter>, IPrinterService
    {
        protected mngPrinter(IUnitOfWork unitOfWork, ISmRepository<mdlPrinter> repository) : base(unitOfWork, repository)
        {
        }
    }
}