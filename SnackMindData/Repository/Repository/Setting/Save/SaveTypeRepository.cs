using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Setting.Save;

using SnackMindModel.Model.Setting.Save;

namespace SnackMindData.Repository.Repository.Setting.Save
{
    public class SaveTypeRepository : SmRepository<mdlSaveType>, ISaveTypeRepository
    {
        public SaveTypeRepository(SmContext context) : base(context)
        {

        }
    }
}