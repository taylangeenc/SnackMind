using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Purchase.Supplier;

using SnackMindModel.Purchase.Supplier;

namespace SnackMindData.Repository.RepositoryBaseClass.Purchase.Supplier
{
    public class SupplierRepository : SmRepository<mdlSupplier>, ISupplierRepository
    {
        public SupplierRepository(SmContext context) : base(context) { }
    }
}