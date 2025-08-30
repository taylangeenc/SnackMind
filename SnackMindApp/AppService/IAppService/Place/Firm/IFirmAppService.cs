using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Place.Firm;

namespace SnackMindApp.AppService.IAppService.Place.Firm
{
    public interface IFirmAppService : ISmAppService<dtoCreateFirm, dtoUpdateFirm, dtoDetailFirm, dtoListFirm>
    {

    }
}