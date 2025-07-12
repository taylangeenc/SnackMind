using SnackMindDTOs.DTOs.Order.Order;
using SnackMindDTOs.DTOs.Place.Branch;
using SnackMindDTOs.DTOs.Product.Stock.Ingredient.IngredientStockMovement;
using SnackMindDTOs.DTOs.Product.Stock.Product.ProductStockMovement;
using SnackMindDTOs.DTOs.Setting.Save.Save;
using SnackMindDTOs.DTOs.User.CashShift;
using SnackMindDTOs.DTOs.User.Role;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.User.User
{
    public class dtoDetailUser : dtoUser
    {
        public string BranchName { get; set; }
        public string RoleName { get; set; }

        public dtoBranch Branch { get; set; }
        public dtoRole Role { get; set; }

        public List<dtoOrder> Orders { get; set; }
        public List<dtoProductStockMovement> ProductStockMovements { get; set; }
        public List<dtoIngredientStockMovement> IngredientStockMovements { get; set; }
        public List<dtoCashShift> CashShifts { get; set; }
        public List<dtoSave> Saves { get; set; }
    }
}