using System;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.Reservation
{
    public class dtoCreateReservation
    {
        public int GuestCount { get; set; }
        public DateTime ReservedDate { get; set; }

        public Guid TableRef { get; set; }
        public Guid CustomerRef { get; set; }
        public Guid ReservationStateRef { get; set; }

        public string Description { get; set; }
    }
}