using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Product;

using SnackMindModel.Product.Stock;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Product
{
    public class ProductStockRepository : SmRepository<mdlProductStock>, IProductStockRepository
    {
        public ProductStockRepository(SmContext context) : base(context) { }
    }
}