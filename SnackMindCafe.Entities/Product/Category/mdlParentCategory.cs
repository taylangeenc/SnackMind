using SnackMindCore.BaseClass;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Category
{
    public class mdlParentCategory : EntityCard
    {
        public virtual ICollection<mdlProductCategory> ProductCategories { get; set; }
    }
}