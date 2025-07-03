using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Product;

using SnackMindService.Service.ServiceBase.Product.Product;

namespace SnackMindService.Service.ServiceBaseClass.Product.Product
{
    public class mngProduct : SmService<mdlProduct>, IProductService
    {
        protected mngProduct(IUnitOfWork unitOfWork, ISmRepository<mdlProduct> repository) : base(unitOfWork, repository)
        {
        }
    }
}