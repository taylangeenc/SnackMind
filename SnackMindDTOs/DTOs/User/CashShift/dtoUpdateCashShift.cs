using System;

namespace SnackMindDTOs.DTOs.User.CashShift
{
    public class dtoUpdateCashShift
    {
        public Guid Ref { get; set; }
        public decimal OpeningCash { get; set; }
        public decimal? ClosingCash { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public Guid BranchRef { get; set; }
        public Guid UserRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}