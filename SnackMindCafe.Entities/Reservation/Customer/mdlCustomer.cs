using SnackMindCore.BaseClass;

using SnackMindModel.Reservation.Reservation;

using System;
using System.Collections.Generic;

namespace SnackMindModel.Reservation.Customer
{
    public class mdlCustomer : EntityCard
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<mdlReservation> Reservations { get; set; }
    }
}