using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Stock;

using SnackMindService.Service.ServiceBase.Product.Stock;

namespace SnackMindService.Service.ServiceBaseClass.Product.Stock
{
    public class mngIngredientStock : SmService<mdlIngredientStock>, IIngredientStockService
    {
        protected mngIngredientStock(IUnitOfWork unitOfWork, ISmRepository<mdlIngredientStock> repository) : base(unitOfWork, repository)
        {
        }
    }
}