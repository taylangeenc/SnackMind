using SnackMindCore.BaseClass;

using SnackMindModel.Model.Place.Branch;

using System;

namespace SnackMindModel.Model.Setting.Printer
{
    public class mdlPrinter : Entity
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public int Quantity { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public Guid PrintDestinationRef { get; set; }
        public virtual mdlPrintDestination PrintDestination { get; set; }

        public Guid PrintStateRef { get; set; }
        public virtual mdlPrintState PrintState { get; set; }

        public Guid PrinterConnectionTypeRef { get; set; }
        public virtual mdlPrinterConnectionType PrinterConnectionType { get; set; }
    }
}