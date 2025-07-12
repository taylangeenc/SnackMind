using System;

namespace SnackMindDTOs.DTOs.Product.Recipe.Recipe
{
    public class dtoCreateRecipe
    {
        public string Name { get; set; }

        public Guid ProductRef { get; set; }

        public string Description { get; set; }
    }
}