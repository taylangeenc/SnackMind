using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Stock;

using SnackMindModel.Model.Product.Stock;

namespace SnackMindData.Repository.Repository.Product.Stock
{
    public class StockMovementTypeRepository : SmRepository<mdlStockMovementType>, IStockMovementTypeRepository
    {
        public StockMovementTypeRepository(SmContext context) : base(context)
        {
            
        }
    }
}