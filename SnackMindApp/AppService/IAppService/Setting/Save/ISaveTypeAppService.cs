using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Setting.Save.SaveType;

namespace SnackMindApp.AppService.IAppService.Setting.Save
{
    public interface ISaveTypeAppService : ISmAppService<dtoCreateSaveType, dtoUpdateSaveType, dtoDetailSaveType, dtoListSaveType>
    {
    }
}