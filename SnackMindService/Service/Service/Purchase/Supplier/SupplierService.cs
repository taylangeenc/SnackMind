using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Purchase.Supplier;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Purchase.Supplier;

namespace SnackMindService.Service.Service.Purchase.Supplier
{
    public class SupplierService : SmService<mdlSupplier>, ISupplierService
    {
        public SupplierService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Supplier)
        {
        }
    }
}