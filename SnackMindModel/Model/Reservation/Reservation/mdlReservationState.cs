using SnackMindCore.BaseClass;

using System.Collections.Generic;

namespace SnackMindModel.Model.Reservation.Reservation
{
    public class mdlReservationState : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<mdlReservation> Reservations { get; set; }
    }
}