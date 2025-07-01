using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Place.Warehouse;

using SnackMindModel.Place.Warehouse;

namespace SnackMindData.Repository.RepositoryBaseClass.Place.Warehouse
{
    public class WarehouseRepository : SmRepository<mdlWarehouse>, IWarehouseRepository
    {
        public WarehouseRepository(SmContext context) : base(context) { }
    }
}