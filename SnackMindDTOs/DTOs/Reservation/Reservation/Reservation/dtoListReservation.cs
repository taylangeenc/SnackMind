namespace SnackMindDTOs.DTOs.Reservation.Reservation.Reservation
{
    public class dtoListReservation : dtoReservation
    {
        public string TableName { get; set; }
        public string CustomerName { get; set; }
        public string ReservationStateName { get; set; }
    }
}