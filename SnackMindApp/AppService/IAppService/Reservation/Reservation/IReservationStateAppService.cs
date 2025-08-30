using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Reservation.Reservation.ReservationState;

namespace SnackMindApp.AppService.IAppService.Reservation.Reservation
{
    public interface IReservationStateAppService : ISmAppService<dtoCreateReservationState, dtoUpdateReservationState, dtoDetailReservationState, dtoListReservationState>
    {
    }
}