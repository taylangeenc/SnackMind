using SnackMindCore.BaseClass;

using SnackMindModel.Model.Reservation.Customer;
using SnackMindModel.Model.Table.Table;

using System;

namespace SnackMindModel.Model.Reservation.Reservation
{
    public class mdlReservation : Entity
    {
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