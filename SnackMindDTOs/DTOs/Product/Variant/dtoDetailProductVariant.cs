using SnackMindDTOs.DTOs.Order.OrderItem;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Variant
{
    public class dtoDetailProductVariant : dtoProductVariant
    {
        public string ProductName { get; set; }

        public List<dtoOrderItem> OrderItems { get; set; }
    }
}