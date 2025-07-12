using SnackMindCore.BaseClass;

using SnackMindModel.Model.Reservation.Reservation;

using System.Collections.Generic;

namespace SnackMindModel.Model.Reservation.Customer
{
    public class mdlCustomer : Entity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<mdlReservation> Reservations { get; set; }
    }
}