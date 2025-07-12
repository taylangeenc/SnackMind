using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Setting.Printer.PrintDestination;
using SnackMindDTOs.DTOs.Setting.Printer.PrinterConnectionType;
using SnackMindDTOs.DTOs.Setting.Printer.PrintState;

namespace SnackMindDTOs.DTOs.Setting.Printer.Printer
{
    public class dtoDetailPrinter : dtoPrinter
    {
        public string BranchName { get; set; }
        public string PrintDestinationName { get; set; }
        public string PrintStateName { get; set; }
        public string PrinterConnectionTypeName { get; set; }

        public dtoBranch Branch { get; set; }
        public dtoPrintDestination PrintDestination { get; set; }
        public dtoPrintState PrintState { get; set; }
        public dtoPrinterConnectionType PrinterConnectionType { get; set; }
    }
}