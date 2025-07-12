using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Setting.Printer
{
    public class mdlPrinterConnectionType : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlPrinter> Printers { get; set; }
    }
}