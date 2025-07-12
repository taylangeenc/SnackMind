using SnackMindDTOs.DTOs.Setting.Printer.Printer;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Setting.Printer.PrintDestination
{
    public class dtoDetailPrintDestination : dtoPrintDestination
    {
        public List<dtoPrinter> Printers { get; set; }
    }
}