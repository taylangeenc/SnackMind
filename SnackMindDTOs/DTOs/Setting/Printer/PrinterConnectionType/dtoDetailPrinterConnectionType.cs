using SnackMindDTOs.DTOs.Setting.Printer.Printer;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Setting.Printer.PrinterConnectionType
{
    public class dtoDetailPrinterConnectionType : dtoPrinterConnectionType
    {
        public List<dtoPrinter> Printers { get; set; }
    }
}