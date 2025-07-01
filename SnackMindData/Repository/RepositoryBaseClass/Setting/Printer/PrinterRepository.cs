using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Setting.Printer;

using SnackMindModel.Setting.Printer;

namespace SnackMindData.Repository.RepositoryBaseClass.Setting.Printer
{
    public class PrinterRepository : SmRepository<mdlPrinter>, IPrinterRepository
    {
        public PrinterRepository(SmContext context) : base(context) { }
    }
}