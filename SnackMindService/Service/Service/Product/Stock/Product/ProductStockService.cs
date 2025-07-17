using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Stock.Product;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Stock.Product;

namespace SnackMindService.Service.Service.Product.Stock.Product
{
    public class ProductStockService : SmService<mdlProductStock>, IProductStockService
    {
        public ProductStockService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ProductStock)
        {
        }
    }
}