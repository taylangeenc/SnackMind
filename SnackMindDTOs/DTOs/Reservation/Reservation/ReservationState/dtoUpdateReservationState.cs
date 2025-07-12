using System;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState
{
    public class dtoUpdateReservationState
    {
        public Guid Ref { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}