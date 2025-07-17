using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Stock;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Stock;

namespace SnackMindService.Service.Service.Product.Stock
{
    public class StockMovementTypeService : SmService<mdlStockMovementType>, IStockMovementTypeService
    {
        public StockMovementTypeService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.StockMovementType)
        {
        }
    }
}