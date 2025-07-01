using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Product;

using SnackMindModel.Product.Product;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Product
{
    public class ProductRepository : SmRepository<mdlProduct>, IProductRepository
    {
        public ProductRepository(SmContext context) : base(context) { }
    }
}