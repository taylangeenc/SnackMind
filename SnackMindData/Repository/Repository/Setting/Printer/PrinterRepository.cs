using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Setting.Printer;

using SnackMindModel.Model.Setting.Printer;

namespace SnackMindData.Repository.Repository.Setting.Printer
{
    public class PrinterRepository : SmRepository<mdlPrinter>, IPrinterRepository
    {
        public PrinterRepository(SmContext context) : base(context)
        {
            
        }
    }
}