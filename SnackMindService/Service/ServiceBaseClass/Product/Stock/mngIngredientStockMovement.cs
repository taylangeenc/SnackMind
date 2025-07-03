using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

namespace SnackMindService.Service.ServiceBaseClass.Product.Stock
{
    public class mngIngredientStockMovement : SmService<mdlIngredientStockMovement>, IIngredientStockMovementService
    {
        protected mngIngredientStockMovement(IUnitOfWork unitOfWork, ISmRepository<mdlIngredientStockMovement> repository) : base(unitOfWork, repository)
        {
        }
    }
}