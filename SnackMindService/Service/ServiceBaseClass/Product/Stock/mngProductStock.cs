using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

namespace SnackMindService.Service.ServiceBaseClass.Product.Stock
{
    public class mngProductStock : SmService<mdlProductStock>, IProductStockService
    {
        protected mngProductStock(IUnitOfWork unitOfWork, ISmRepository<mdlProductStock> repository) : base(unitOfWork, repository)
        {
        }
    }
}