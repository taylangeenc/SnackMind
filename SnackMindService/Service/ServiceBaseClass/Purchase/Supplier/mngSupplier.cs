using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Purchase.Supplier;

using SnackMindService.Service.ServiceBase.Purchase.Supplier;

namespace SnackMindService.Service.ServiceBaseClass.Purchase.Supplier
{
    public class mngSupplier : SmService<mdlSupplier>, ISupplierService
    {
        protected mngSupplier(IUnitOfWork unitOfWork, ISmRepository<mdlSupplier> repository) : base(unitOfWork, repository)
        {
        }
    }
}