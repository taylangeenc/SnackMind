using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Category
{
    public class mdlProductCategory : Entity
    {
        public string Name { get; set; }

        public Guid ParentCategoryRef { get; set; }
        public virtual mdlParentCategory ParentCategory { get; set; }

        public virtual ICollection<mdlProduct> Products { get; set; }
    }
}