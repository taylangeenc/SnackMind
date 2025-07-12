using System;

namespace SnackMindDTOs.DTOs.Setting.Printer.Printer
{
    public class dtoCreatePrinter
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public int Quantity { get; set; }

        public Guid BranchRef { get; set; }
        public Guid PrintDestinationRef { get; set; }
        public Guid PrintStateRef { get; set; }
        public Guid PrinterConnectionTypeRef { get; set; }

        public string Description { get; set; }
    }
}