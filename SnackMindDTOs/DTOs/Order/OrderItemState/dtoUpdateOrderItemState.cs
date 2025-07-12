using System;

namespace SnackMindDTOs.DTOs.Order.OrderItemState
{
    public class dtoUpdateOrderItemState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}