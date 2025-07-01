using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Unit;

using SnackMindModel.Product.Unit;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Unit
{
    public class UnitRepository : SmRepository<mdlUnit>, IUnitRepository
    {
        public UnitRepository(SmContext context) : base(context) { }
    }
}