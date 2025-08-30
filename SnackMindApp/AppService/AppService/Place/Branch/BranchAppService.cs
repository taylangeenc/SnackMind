using AutoMapper;

using FluentValidation;

using SnackMindApp.AppService.BaseClass;
using SnackMindApp.AppService.IAppService.Place.Branch;

using SnackMindDTOs.DTOs.Place.Branch;

using SnackMindModel.Model.Place.Branch;

using SnackMindService.Service.Base;

namespace SnackMindApp.AppService.AppService.Place.Branch
{
    public class BranchAppService : SmAppService<dtoCreateBranch, dtoUpdateBranch, dtoDetailBranch, dtoListBranch, mdlBranch>, IBranchAppService
    {
        public BranchAppService(ISmService<mdlBranch> service, IMapper mapper, IValidator<dtoCreateBranch> createValidator, IValidator<dtoUpdateBranch> updateValidator) : base(service, mapper, createValidator, updateValidator)
        {

        }
    }
}