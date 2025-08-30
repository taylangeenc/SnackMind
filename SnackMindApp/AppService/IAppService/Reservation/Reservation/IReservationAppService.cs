using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;

namespace SnackMindApp.AppService.IAppService.Reservation.Reservation
{
    public interface IReservationAppService : ISmAppService<dtoCreateReservation, dtoUpdateReservation, dtoDetailReservation, dtoListReservation>
    {
    }
}