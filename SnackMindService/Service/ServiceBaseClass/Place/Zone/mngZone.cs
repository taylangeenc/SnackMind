using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Place.Zone;

using SnackMindService.Service.ServiceBase.Place.Zone;

namespace SnackMindService.Service.ServiceBaseClass.Place.Zone
{
    public class mngZone : SmService<mdlZone>, IZoneService
    {
        protected mngZone(IUnitOfWork unitOfWork, ISmRepository<mdlZone> repository) : base(unitOfWork, repository)
        {
        }
    }
}