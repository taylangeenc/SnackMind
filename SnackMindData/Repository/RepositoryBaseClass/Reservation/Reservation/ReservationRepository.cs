using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Reservation.Reservation;

using SnackMindModel.Reservation.Reservation;

namespace SnackMindData.Repository.RepositoryBaseClass.Reservation.Reservation
{
    public class ReservationRepository : SmRepository<mdlReservation>, IReservationRepository
    {
        public ReservationRepository(SmContext context) : base(context) { }
    }
}