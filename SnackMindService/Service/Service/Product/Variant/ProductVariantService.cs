using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Variant;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Variant;

namespace SnackMindService.Service.Service.Product.Variant
{
    public class ProductVariantService : SmService<mdlProductVariant>, IProductVariantService
    {
        public ProductVariantService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ProductVariant)
        {
        }
    }
}