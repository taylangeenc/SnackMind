using SnackMindDTOs.DTOs.Payment.Payment.Payment;
using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.User.User;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.User.CashShift
{
    public class dtoDetailCashShift : dtoCashShift
    {
        public string BranchName { get; set; }
        public string UserFullName { get; set; }

        public dtoBranch Branch { get; set; }
        public dtoUser User { get; set; }
        public List<dtoPayment> Payments { get; set; }
    }
}