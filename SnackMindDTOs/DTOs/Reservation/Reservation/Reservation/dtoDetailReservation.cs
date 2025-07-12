using SnackMindDTOs.DTOs.Reservation.Customer;
using SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState;
using SnackMindDTOs.DTOs.Table.Table.Table;

namespace SnackMindDTOs.DTOs.Reservation.Reservation.Reservation
{
    public class dtoDetailReservation : dtoReservation
    {
        public string TableName { get; set; }
        public string CustomerName { get; set; }
        public string ReservationStateName { get; set; }

        public dtoTable Table { get; set; }
        public dtoCustomer Customer { get; set; }
        public dtoReservationState ReservationState { get; set; }
    }
}