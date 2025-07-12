using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Category
{
    public class mdlParentCategory : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlProductCategory> ProductCategories { get; set; }
    }
}