using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Purchase.Supplier;

using SnackMindModel.Model.Purchase.Supplier;

namespace SnackMindData.Repository.Repository.Purchase.Supplier
{
    public class SupplierRepository : SmRepository<mdlSupplier>, ISupplierRepository
    {
        public SupplierRepository(SmContext context) : base(context)
        {
            
        }
    }
}