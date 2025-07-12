using SnackMindDTOs.DTOs.Product.Category.ProductCategory;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Category.ParentCategory
{
    public class dtoDetailParentCategory : dtoParentCategory
    {
        public List<dtoProductCategory> ProductCategories { get; set; }
    }
}