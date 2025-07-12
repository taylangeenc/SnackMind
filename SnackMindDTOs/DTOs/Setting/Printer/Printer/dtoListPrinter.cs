namespace SnackMindDTOs.DTOs.Setting.Printer.Printer
{
    public class dtoListPrinter : dtoPrinter
    {
        public string BranchName { get; set; }
        public string PrintDestinationName { get; set; }
        public string PrintStateName { get; set; }
        public string PrinterConnectionTypeName { get; set; }
    }
}