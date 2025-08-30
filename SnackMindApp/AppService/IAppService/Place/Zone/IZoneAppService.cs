using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Place.Zone;

namespace SnackMindApp.AppService.IAppService.Place.Zone
{
    public interface IZoneAppService : ISmAppService<dtoCreateZone, dtoUpdateZone, dtoDetailZone, dtoListZone>
    {
    }
}