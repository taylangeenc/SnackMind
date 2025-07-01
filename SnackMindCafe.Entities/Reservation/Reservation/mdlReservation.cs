using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Reservation.Customer;
using SnackMindModel.Table.Table;

using System;

namespace SnackMindModel.Reservation.Reservation
{
    public class mdlReservation : Entity
    {
        public string Description { get; set; }
        public int GuestCount { get; set; }
        public DateTime ReservedDate { get; set; }

        public Guid TableRef { get; set; }
        public virtual mdlTable Table { get; set; }

        public Guid CustomerRef { get; set; }
        public virtual mdlCustomer Customer { get; set; }

        public Guid ReservationStateRef { get; set; }
        public virtual mdlReservationState ReservationState { get; set; }
    }
}