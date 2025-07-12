using System;

namespace SnackMindDTOs.DTOs.Product.Unit
{
    public class dtoUnit
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool IsDefault { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}