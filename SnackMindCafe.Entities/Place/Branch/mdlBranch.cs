using SnackMindCore.BaseClass;

using SnackMindModel.Order.Order;
using SnackMindModel.Place.Firm;
using SnackMindModel.Place.Warehouse;
using SnackMindModel.Place.Zone;
using SnackMindModel.Setting.Log;
using SnackMindModel.Setting.Printer;
using SnackMindModel.User.CashShift;
using SnackMindModel.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Place.Branch
{
    public class mdlBranch : EntityCard
    {
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
        public virtual ICollection<mdlLog> Logs { get; set; }
    }
}