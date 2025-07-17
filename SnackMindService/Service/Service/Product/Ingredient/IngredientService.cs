using SnackMindData.Repository.Base;
using SnackMindData.UnitOfWork;

using SnackMindModel.Model.Product.Ingredient;

using SnackMindService.Service.BaseClass;
using SnackMindService.Service.IService.Product.Ingredient;

namespace SnackMindService.Service.Service.Product.Ingredient
{
    public class IngredientService : SmService<mdlIngredient>, IIngredientService
    {
        public IngredientService(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.Ingredient)
        {
        }
    }
}