using SnackMindCore.BaseClass;

using SnackMindModel.Order.Order;
using SnackMindModel.Place.Branch;
using SnackMindModel.Product.Stock;
using SnackMindModel.Setting.Log;
using SnackMindModel.User.CashShift;
using SnackMindModel.User.Role;

using System;
using System.Collections.Generic;

namespace SnackMindModel.User.User
{
    public class mdlUser : EntityCard
    {
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
        public virtual ICollection<mdlLog> Logs { get; set; }
    }
}