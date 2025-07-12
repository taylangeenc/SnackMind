using SnackMindDTOs.DTOs.Order.OrderItem;
using SnackMindDTOs.DTOs.Payment.Payment.Payment;
using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Table.Table.Table;
using SnackMindDTOs.DTOs.User.User;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Order.Order
{
    public class dtoDetailOrder : dtoOrder
    {
        public string BranchName { get; set; }
        public string TableName { get; set; }
        public string UserFullName { get; set; }

        public dtoBranch Branch { get; set; }
        public dtoTable Table { get; set; }
        public dtoUser User { get; set; }

        public List<dtoOrderItem> OrderItems { get; set; }
        public List<dtoPayment> Payments { get; set; }
    }
}