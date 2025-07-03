using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Recipe.Recipe;

using SnackMindService.Service.ServiceBase.Product.Recipe.Recipe;

namespace SnackMindService.Service.ServiceBaseClass.Product.Recipe.Recipe
{
    public class mngRecipe : SmService<mdlRecipe>, IRecipeService
    {
        protected mngRecipe(IUnitOfWork unitOfWork, ISmRepository<mdlRecipe> repository) : base(unitOfWork, repository)
        {
        }
    }
}