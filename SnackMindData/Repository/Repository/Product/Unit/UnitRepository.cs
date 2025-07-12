using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Unit;

using SnackMindModel.Model.Product.Unit;

namespace SnackMindData.Repository.Repository.Product.Unit
{
    public class UnitRepository : SmRepository<mdlUnit>, IUnitRepository
    {
        public UnitRepository(SmContext context) : base(context)
        {
            
        }
    }
}