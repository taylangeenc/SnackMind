using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Place.Warehouse;

using SnackMindModel.Model.Place.Warehouse;

namespace SnackMindData.Repository.Repository.Place.Warehouse
{
    public class WarehouseRepository : SmRepository<mdlWarehouse>, IWarehouseRepository
    {
        public WarehouseRepository(SmContext context) : base(context)
        {
            
        }
    }
}