using System;

namespace SnackMindDTOs.DTOs.Product.Category.ProductCategory
{
    public class dtoUpdateProductCategory
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public Guid ProductCategoryRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}