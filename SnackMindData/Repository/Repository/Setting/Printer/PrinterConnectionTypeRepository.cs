using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Setting.Printer;

using SnackMindModel.Model.Setting.Printer;

namespace SnackMindData.Repository.Repository.Setting.Printer
{
    public class PrinterConnectionTypeRepository : SmRepository<mdlPrinterConnectionType>, IPrinterConnectionTypeRepository
    {
        public PrinterConnectionTypeRepository(SmContext context) : base(context)
        {

        }
    }
}