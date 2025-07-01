using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Order.Order;
using SnackMindModel.Place.Zone;
using SnackMindModel.Reservation.Reservation;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Table.Table
{
    public class mdlTable : EntityCard
    {
        public string Code { get; set; }
        public int Capacity { get; set; }
        public bool IsCanReserved { get; set; }

        public Guid ZoneRef { get; set; }
        public virtual mdlZone Zone { get; set; }

        public Guid TableStateRef { get; set; }
        public virtual mdlTableState TableState { get; set; }

        public virtual ICollection<mdlOrder> Orders { get; set; }
        public virtual ICollection<mdlReservation> Reservations { get; set; }

    }
}