using SnackMindDTOs.DTOs.Order.Order;
using SnackMindDTOs.DTOs.Place.Warehouse;
using SnackMindDTOs.DTOs.Place.Zone;
using SnackMindDTOs.DTOs.Setting.Printer.Printer;
using SnackMindDTOs.DTOs.Setting.Save.Save;
using SnackMindDTOs.DTOs.User.CashShift;
using SnackMindDTOs.DTOs.User.User;

using System;
using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Place.Branch
{
    public class dtoDetailBranch : dtoBranch
    {
        public string DatabaseName { get; set; }
        public Guid FirmRef { get; set; }
        public string FirmName { get; set; }

        public List<dtoWarehouse> Warehouses { get; set; }
        public List<dtoZone> Zones { get; set; }
        public List<dtoPrinter> Printers { get; set; }
        public List<dtoOrder> Orders { get; set; }
        public List<dtoCashShift> CashShifts { get; set; }
        public List<dtoUser> Users { get; set; }
        public List<dtoSave> Saves { get; set; }
    }
}