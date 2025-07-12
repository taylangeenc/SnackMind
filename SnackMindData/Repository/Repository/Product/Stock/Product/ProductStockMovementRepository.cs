using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Stock.Product;

using SnackMindModel.Model.Product.Stock.Product;

namespace SnackMindData.Repository.Repository.Product.Stock.Product
{
    public class ProductStockMovementRepository : SmRepository<mdlProductStockMovement>, IProductStockMovementRepository
    {
        public ProductStockMovementRepository(SmContext context) : base(context)
        {
            
        }
    }
}