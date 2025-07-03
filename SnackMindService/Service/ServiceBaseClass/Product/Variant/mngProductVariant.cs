using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Variant;

using SnackMindService.Service.ServiceBase.Product.Variant;

namespace SnackMindService.Service.ServiceBaseClass.Product.Variant
{
    public class mngProductVariant : SmService<mdlProductVariant>, IProductVariantService
    {
        protected mngProductVariant(IUnitOfWork unitOfWork, ISmRepository<mdlProductVariant> repository) : base(unitOfWork, repository)
        {
        }
    }
}