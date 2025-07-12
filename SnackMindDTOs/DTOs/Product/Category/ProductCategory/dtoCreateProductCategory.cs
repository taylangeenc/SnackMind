using System;

namespace SnackMindDTOs.DTOs.Product.Category.ProductCategory
{
    public class dtoCreateProductCategory
    {
        public string Name { get; set; }

        public Guid ParentCategoryRef { get; set; }

        public string Description { get; set; }
    }
}