namespace SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement
{
    public class dtoListIngredientStockMovement : dtoIngredientStockMovement
    {
        public string UnitName { get; set; }
        public string WarehouseName { get; set; }
        public string UserName { get; set; }
        public string StockMovementTypeName { get; set; }
    }
}