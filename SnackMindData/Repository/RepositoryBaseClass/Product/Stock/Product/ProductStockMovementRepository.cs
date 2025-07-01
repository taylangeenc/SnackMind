using SnackMindData.Context;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Product
{
    public class ProductStockMovementRepository : SmRepository<mdlProductStockMovement>
    {
        public ProductStockMovementRepository(SmContext context) : base(context) { }
    }
}