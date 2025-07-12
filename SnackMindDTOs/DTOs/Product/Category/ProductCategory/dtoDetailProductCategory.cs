using SnackMindDTOs.DTOs.Product.Product;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Product.Category.ProductCategory
{
    public class dtoDetailProductCategory : dtoProductCategory
    {
        public string ParentCategoryName { get; set; }

        public List<dtoProduct> Products { get; set; }
    }
}