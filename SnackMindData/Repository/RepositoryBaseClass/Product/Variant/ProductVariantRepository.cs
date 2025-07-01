using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Product.Variant;

using SnackMindModel.Product.Variant;

namespace SnackMindData.Repository.RepositoryBaseClass.Product.Variant
{
    public class ProductVariantRepository : SmRepository<mdlProductVariant>, IProductVariantRepository
    {
        public ProductVariantRepository(SmContext context) : base(context) { }
    }
}