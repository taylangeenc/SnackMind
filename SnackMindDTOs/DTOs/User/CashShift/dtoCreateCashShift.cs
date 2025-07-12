using System;

namespace SnackMindDTOs.DTOs.User.CashShift
{
    public class dtoCreateCashShift
    {
        public decimal OpeningCash { get; set; }
        public DateTime OpenedDate { get; set; }

        public Guid BranchRef { get; set; }
        public Guid UserRef { get; set; }

        public string Description { get; set; }
    }
}