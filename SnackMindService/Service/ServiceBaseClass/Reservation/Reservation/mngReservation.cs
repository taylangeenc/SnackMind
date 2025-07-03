using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Reservation.Reservation;

using SnackMindService.Service.ServiceBase.Reservation.Reservation;

namespace SnackMindService.Service.ServiceBaseClass.Reservation.Reservation
{
    public class mngReservation : SmService<mdlReservation>, IReservationService
    {
        protected mngReservation(IUnitOfWork unitOfWork, ISmRepository<mdlReservation> repository) : base(unitOfWork, repository)
        {
        }
    }
}