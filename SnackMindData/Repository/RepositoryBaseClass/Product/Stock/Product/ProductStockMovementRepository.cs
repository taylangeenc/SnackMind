using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Product;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Product
{
    public class ProductStockMovementRepository : SmRepository<mdlProductStockMovement>, IProductStockMovementRepository
    {
        public ProductStockMovementRepository(SmContext context) : base(context) { }
    }
}