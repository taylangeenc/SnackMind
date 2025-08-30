using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Save.Save;

namespace SnackMindApp.AppService.IAppService.Setting.Save
{
    public interface ISaveAppService : ISmAppService<dtoCreateSave, dtoUpdateSave, dtoDetailSave, dtoListSave>
    {
    }
}