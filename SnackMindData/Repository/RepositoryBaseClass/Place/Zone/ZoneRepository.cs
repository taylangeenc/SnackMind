using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Place.Zone;

using SnackMindModel.Place.Zone;

namespace SnackMindData.Repository.RepositoryBaseClass.Place.Zone
{
    public class ZoneRepository : SmRepository<mdlZone>, IZoneRepository
    {
        public ZoneRepository(SmContext context) : base(context) { }
    }
}