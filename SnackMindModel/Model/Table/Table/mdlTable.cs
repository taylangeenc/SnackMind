using SnackMindCore.BaseClass;

using SnackMindModel.Model.Order.Order;
using SnackMindModel.Model.Place.Zone;
using SnackMindModel.Model.Reservation.Reservation;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Model.Table.Table
{
    public class mdlTable : Entity
    {
        public string Name { get; set; }
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