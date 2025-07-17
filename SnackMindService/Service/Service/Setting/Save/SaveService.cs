using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Setting.Save;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Setting.Save;

namespace SnackMindService.Service.Service.Setting.Save
{
    public class SaveService : SmService<mdlSave>, ISaveService
    {
        public SaveService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Save)
        {
        }
    }
}