using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Reservation.Reservation;

using SnackMindModel.Model.Reservation.Reservation;

namespace SnackMindData.Repository.Repository.Reservation.Reservation
{
    public class ReservationStateRepository : SmRepository<mdlReservationState>, IReservationStateRepository
    {
        public ReservationStateRepository(SmContext context) : base(context)
        {
            
        }
    }
}