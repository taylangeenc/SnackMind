using SnackMindData.Context;
using SnackMindData.Repository.BaseClass;
using SnackMindData.Repository.IRepository.Product.Variant;

using SnackMindModel.Model.Product.Variant;

namespace SnackMindData.Repository.Repository.Product.Variant
{
    public class ProductVariantRepository : SmRepository<mdlProductVariant>, IProductVariantRepository
    {
        public ProductVariantRepository(SmContext context) : base(context)
        {
            
        }
    }
}