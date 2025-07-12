using System;

namespace SnackMindDTOs.DTOs.Product.Variant
{
    public class dtoUpdateProductVariant
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }

        public Guid ProductRef { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}