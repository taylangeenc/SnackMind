using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Stock.Product;

using SnackMindModel.Model.Product.Stock.Product;

namespace SnackMindData.Repository.Repository.Product.Stock.Product
{
    public class ProductStockRepository : SmRepository<mdlProductStock>, IProductStockRepository
    {
        public ProductStockRepository(SmContext context) : base(context)
        {
            
        }
    }
}