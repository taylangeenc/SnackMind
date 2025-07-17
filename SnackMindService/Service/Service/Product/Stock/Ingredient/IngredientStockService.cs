using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Stock.Ingredient;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Stock.Ingredient;

namespace SnackMindService.Service.Service.Product.Stock.Ingredient
{
    public class IngredientStockService : SmService<mdlIngredientStock>, IIngredientStockService
    {
        public IngredientStockService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.IngredientStock)
        {
        }
    }
}