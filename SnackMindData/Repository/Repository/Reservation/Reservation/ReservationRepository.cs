using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Reservation.Reservation;

using SnackMindModel.Model.Reservation.Reservation;

namespace SnackMindData.Repository.Repository.Reservation.Reservation
{
    public class ReservationRepository : SmRepository<mdlReservation>, IReservationRepository
    {
        public ReservationRepository(SmContext context) : base(context)
        {
            
        }
    }
}