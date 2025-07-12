using SnackMindDTOs.DTOs.Order.OrderItemState;
using SnackMindDTOs.DTOs.Product.Product;
using SnackMindDTOs.DTOs.Product.Variant;

namespace SnackMindDTOs.DTOs.Order.OrderItem
{
    public class dtoDetailOrderItem : dtoOrderItem
    {
        public dtoProduct Product { get; set; }
        public dtoProductVariant ProductVariant { get; set; }
        public dtoOrderItemState OrderItemState { get; set; }
    }
}