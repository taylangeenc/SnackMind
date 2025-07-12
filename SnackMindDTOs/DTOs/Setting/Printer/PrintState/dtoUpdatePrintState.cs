using System;

namespace SnackMindDTOs.DTOs.Setting.Printer.PrintState
{
    public class dtoUpdatePrintState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}