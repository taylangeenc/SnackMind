using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Place.Zone;

using SnackMindModel.Model.Place.Zone;

namespace SnackMindData.Repository.Repository.Place.Zone
{
    public class ZoneRepository : SmRepository<mdlZone>, IZoneRepository
    {
        public ZoneRepository(SmContext context) : base(context)
        {
            
        }
    }
}