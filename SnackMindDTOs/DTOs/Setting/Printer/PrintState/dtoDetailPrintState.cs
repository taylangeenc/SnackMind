using SnackMindDTOs.DTOs.Setting.Printer.Printer;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Setting.Printer.PrintState
{
    public class dtoDetailPrintState : dtoPrintState
    {
        public List<dtoPrinter> Printers { get; set; }
    }
}