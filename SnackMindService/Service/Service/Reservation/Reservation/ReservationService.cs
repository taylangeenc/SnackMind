using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Reservation.Reservation;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Reservation.Reservation;

namespace SnackMindService.Service.Service.Reservation.Reservation
{
    public class ReservationService : SmService<mdlReservation>, IReservationService
    {
        public ReservationService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Reservation)
        {
        }
    }
}