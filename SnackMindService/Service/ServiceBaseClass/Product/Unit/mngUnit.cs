using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Unit;

using SnackMindService.Service.ServiceBase.Product.Unit;

namespace SnackMindService.Service.ServiceBaseClass.Product.Unit
{
    public class mngUnit : SmService<mdlUnit>, IUnitService
    {
        protected mngUnit(IUnitOfWork unitOfWork, ISmRepository<mdlUnit> repository) : base(unitOfWork, repository)
        {
        }
    }
}