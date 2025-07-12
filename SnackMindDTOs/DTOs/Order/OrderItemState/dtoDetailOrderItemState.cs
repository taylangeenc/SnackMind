using SnackMindDTOs.DTOs.Order.OrderItem;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Order.OrderItemState
{
    public class dtoDetailOrderItemState : dtoOrderItemState
    {
        public List<dtoOrderItem> OrderItems { get; set; }
    }
}