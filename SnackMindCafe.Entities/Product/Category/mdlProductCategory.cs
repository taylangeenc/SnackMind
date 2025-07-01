using SnackMindCore.BaseClass;

using SnackMindModel.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Category
{
    public class mdlProductCategory : EntityCard
    {
        public Guid ParentCategoryRef { get; set; }
        public virtual mdlParentCategory ParentCategory { get; set; }

        public virtual ICollection<mdlProduct> Products { get; set; }
    }
}