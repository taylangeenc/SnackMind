using SnackMindDTOs.DTOs.Product.Ingredient;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient
{
    public class dtoDetailIngredientPurchaseOrderItem : dtoIngredientPurchaseOrderItem
    {
        public string IngredientName { get; set; }
        public string PurchaseOrderCode { get; set; }

        public dtoIngredient Ingredient { get; set; }
    }
}