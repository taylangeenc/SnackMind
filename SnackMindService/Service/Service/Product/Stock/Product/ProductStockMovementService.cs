using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Stock.Product;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Stock.Product;

namespace SnackMindService.Service.Service.Product.Stock.Product
{
    public class ProductStockMovementService : SmService<mdlProductStockMovement>, IProductStockMovementService
    {
        public ProductStockMovementService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ProductStockMovement)
        {
        }
    }
}