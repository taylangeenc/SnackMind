using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

namespace SnackMindService.Service.ServiceBaseClass.Product.Stock
{
    public class mngProductStockMovement : SmService<mdlProductStockMovement>, IProductStockMovementService
    {
        protected mngProductStockMovement(IUnitOfWork unitOfWork, ISmRepository<mdlProductStockMovement> repository) : base(unitOfWork, repository)
        {
        }
    }
}