using System;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState
{
    public class dtoReservationState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}