using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;

using System.Collections.Generic;

namespace SnackMindDTOs.DTOs.Reservation.Customer
{
    public class dtoDetailCustomer : dtoCustomer
    {
        public List<dtoReservation> Reservations { get; set; }
    }
}