using SnackMindDTOs.DTOs.Order.OrderItem;

using System;
using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Order.Order
{
    public class dtoUpdateOrder
    {
        public Guid Ref { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public Guid BranchRef { get; set; }
        public Guid TableRef { get; set; }
        public Guid UserRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<dtoUpdateOrderItem> OrderItems { get; set; }
    }
}