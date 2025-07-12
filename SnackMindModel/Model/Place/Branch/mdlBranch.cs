using SnackMindCore.BaseClass;

using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Place.Firm;
using SnackMindModel.Model.Place.Warehouse;
using SnackMindModel.Model.Place.Zone;
using SnackMindModel.Model.Setting.Printer;
using SnackMindModel.Model.Setting.Save;
using SnackMindModel.Model.User.CashShift;
using SnackMindModel.Model.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Place.Branch
{
    public class mdlBranch : Entity
    {
        public string Name { get; set; }
        public string DatabaseName { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guid FirmRef { get; set; }
        public virtual mdlFirm Firm { get; set; }

        public virtual ICollection<mdlWarehouse> Warehouses { get; set; }
        public virtual ICollection<mdlZone> Zones { get; set; }
        public virtual ICollection<mdlPrinter> Printers { get; set; }
        public virtual ICollection<mdlOrder> Orders { get; set; }
        public virtual ICollection<mdlCashShift> CashShifts { get; set; }
        public virtual ICollection<mdlUser> Users { get; set; }
        public virtual ICollection<mdlSave> Saves { get; set; }
    }
}