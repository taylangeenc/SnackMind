using SnackMindCore.BaseClass;

using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;

using System.Collections.Generic;

namespace SnackMindModel.Model.Product.Stock
{
    public class mdlStockMovementType : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
    }
}