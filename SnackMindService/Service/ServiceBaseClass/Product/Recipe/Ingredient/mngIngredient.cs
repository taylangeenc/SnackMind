using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Recipe.Ingredient;

using SnackMindService.Service.ServiceBase.Product.Recipe.Ingredient;

namespace SnackMindService.Service.ServiceBaseClass.Product.Recipe.Ingredient
{
    public class mngIngredient : SmService<mdlIngredient>, IIngredientService
    {
        protected mngIngredient(IUnitOfWork unitOfWork, ISmRepository<mdlIngredient> repository) : base(unitOfWork, repository)
        {
        }
    }
}