using SnackMindDTOs.DTOs.Order.OrderItem;

using System;
using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Order.Order
{
    public class dtoCreateOrder
    {
        public Guid BranchRef { get; set; }
        public Guid TableRef { get; set; }
        public Guid UserRef { get; set; }

        public string Description { get; set; }
        public List<dtoCreateOrderItem> OrderItems { get; set; }
    }
}