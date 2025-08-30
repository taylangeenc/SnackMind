using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Product.Unit;

namespace SnackMindApp.AppService.IAppService.Product.Unit
{
    public interface IUnitAppService : ISmAppService<dtoCreateUnit, dtoUpdateUnit, dtoDetailUnit, dtoListUnit>
    {
    }
}