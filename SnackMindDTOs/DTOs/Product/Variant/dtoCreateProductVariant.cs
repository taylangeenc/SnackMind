using System;

namespace SnackMindDTOs.DTOs.Product.Variant
{
    public class dtoCreateProductVariant
    {
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }

        public Guid ProductRef { get; set; }
        public string Description { get; set; }
    }
}