namespace SnackMindDTOs.DTOs.Order.OrderItem
{
    public class dtoListOrderItem : dtoOrderItem
    {
        public string ProductName { get; set; }
        public string ProductVariantName { get; set; }
        public string OrderItemStateName { get; set; }
    }
}