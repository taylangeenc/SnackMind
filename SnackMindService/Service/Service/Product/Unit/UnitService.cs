using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Unit;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Unit;

namespace SnackMindService.Service.Service.Product.Unit
{
    public class UnitService : SmService<mdlUnit>, IUnitService
    {
        public UnitService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Unit)
        {
        }
    }
}