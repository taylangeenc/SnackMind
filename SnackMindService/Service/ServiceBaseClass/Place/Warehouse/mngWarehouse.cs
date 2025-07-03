using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Place.Warehouse;

using SnackMindService.Service.ServiceBase.Place.Warehouse;

namespace SnackMindService.Service.ServiceBaseClass.Place.Warehouse
{
    public class mngWarehouse : SmService<mdlWarehouse>, IWarehouseService
    {
        protected mngWarehouse(IUnitOfWork unitOfWork, ISmRepository<mdlWarehouse> repository) : base(unitOfWork, repository)
        {
        }
    }
}