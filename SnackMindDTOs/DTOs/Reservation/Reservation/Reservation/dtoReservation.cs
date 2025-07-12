using System;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.Reservation
{
    public class dtoReservation
    {
        public Guid Ref { get; set; }
        public int GuestCount { get; set; }
        public DateTime ReservedDate { get; set; }

        public Guid TableRef { get; set; }
        public Guid CustomerRef { get; set; }
        public Guid ReservationStateRef { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}