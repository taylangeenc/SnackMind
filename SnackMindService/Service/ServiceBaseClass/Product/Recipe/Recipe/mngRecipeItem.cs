using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Product.Recipe.Recipe;

using SnackMindService.Service.ServiceBase.Product.Recipe.Recipe;

namespace SnackMindService.Service.ServiceBaseClass.Product.Recipe.Recipe
{
    public class mngRecipeItem : SmService<mdlRecipeItem>, IRecipeItemService
    {
        protected mngRecipeItem(IUnitOfWork unitOfWork, ISmRepository<mdlRecipeItem> repository) : base(unitOfWork, repository)
        {
        }
    }
}