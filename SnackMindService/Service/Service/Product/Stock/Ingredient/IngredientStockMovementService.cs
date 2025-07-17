using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Stock.Ingredient;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Stock.Ingredient;

namespace SnackMindService.Service.Service.Product.Stock.Ingredient
{
    public class IngredientStockMovementService : SmService<mdlIngredientStockMovement>, IIngredientStockMovementService
    {
        public IngredientStockMovementService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.IngredientStockMovement)
        {
        }
    }
}