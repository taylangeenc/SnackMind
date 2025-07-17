using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Setting.Save;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Setting.Save;

namespace SnackMindService.Service.Service.Setting.Save
{
    public class SaveTypeService : SmService<mdlSaveType>, ISaveTypeService
    {
        public SaveTypeService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.SaveType)
        {
        }
    }
}