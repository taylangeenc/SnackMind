using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Place.Branch;

namespace SnackMindApp.AppService.IAppService.Place.Branch
{
    public interface IBranchAppService : ISmAppService<dtoCreateBranch, dtoUpdateBranch, dtoDetailBranch, dtoListBranch>
    {

    }
}