using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Product;

using SnackMindModel.Model.Product.Product;

namespace SnackMindData.Repository.Repository.Product.Product
{
    public class ProductRepository : SmRepository<mdlProduct>, IProductRepository
    {
        public ProductRepository(SmContext context) : base(context)
        {
            
        }
    }
}