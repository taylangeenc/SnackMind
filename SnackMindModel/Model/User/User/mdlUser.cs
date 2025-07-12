using SnackMindCore.BaseClass;

using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Place.Branch;
using SnackMindModel.Model.Product.Stock.Ingredient;
using SnackMindModel.Model.Product.Stock.Product;
using SnackMindModel.Model.Setting.Save;
using SnackMindModel.Model.User.CashShift;
using SnackMindModel.Model.User.Role;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.User.User
{
    public class mdlUser : Entity
    {
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public Guid BranchRef { get; set; }
        public virtual mdlBranch Branch { get; set; }

        public Guid RoleRef { get; set; }
        public virtual mdlRole Role { get; set; }

        public virtual ICollection<mdlOrder> Orders { get; set; }
        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
        public virtual ICollection<mdlCashShift> CashShifts { get; set; }
        public virtual ICollection<mdlSave> Saves { get; set; }

    }
}