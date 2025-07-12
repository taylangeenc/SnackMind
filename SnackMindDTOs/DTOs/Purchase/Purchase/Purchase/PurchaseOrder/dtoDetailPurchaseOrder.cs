using SnackMindDTOs.DTOs.Purchase.Purchase.Ingredient;
using SnackMindDTOs.DTOs.Purchase.Purchase.Product;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Purchase.Purchase.Purchase.PurchaseOrder
{
    public class dtoDetailPurchaseOrder : dtoPurchaseOrder
    {
        public string SupplierName { get; set; }
        public string PurchaseOrderStateName { get; set; }

        public List<dtoProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
        public List<dtoIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
    }
}