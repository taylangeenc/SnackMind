using System;

namespace SnackMindDTOs.DTOs.Order.OrderItem
{
    public class dtoUpdateOrderItem
    {
        public Guid Ref { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsPrintedToKitchen { get; set; }

        public Guid ProductRef { get; set; }
        public Guid ProductVariantRef { get; set; }
        public Guid OrderRef { get; set; }
        public Guid OrderItemStateRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}