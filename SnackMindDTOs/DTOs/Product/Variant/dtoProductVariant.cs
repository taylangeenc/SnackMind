using System;

namespace SnackMindDTOs.DTOs.Product.Variant
{
    public class dtoProductVariant
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }

        public Guid ProductRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}