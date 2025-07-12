using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState
{
    public class dtoDetailReservationState : dtoReservationState
    {
        public List<dtoReservation> Reservations { get; set; }
    }
}