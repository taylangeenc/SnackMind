using System;

namespace SnackMindDTOs.DTOs.Product.Recipe.Recipe
{
    public class dtoUpdateRecipe
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public Guid ProductRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}