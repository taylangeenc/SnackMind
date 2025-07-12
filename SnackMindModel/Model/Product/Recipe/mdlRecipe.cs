using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Recipe
{
    public class mdlRecipe : Entity
    {
        public string Name { get; set; }

        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public virtual ICollection<mdlRecipeItem> RecipeItems { get; set; }
    }
}