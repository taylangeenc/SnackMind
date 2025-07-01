using SnackMindCore.BaseClass;

using SnackMindModel.Product.Product;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Product.Recipe.Recipe
{
    public class mdlRecipe : EntityCard
    {
        public Guid ProductRef { get; set; }
        public virtual mdlProduct Product { get; set; }

        public virtual ICollection<mdlRecipeItem> RecipeItems { get; set; }
    }
}