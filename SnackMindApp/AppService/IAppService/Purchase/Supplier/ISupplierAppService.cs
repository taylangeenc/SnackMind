using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.Purchase.Supplier;

namespace SnackMindApp.AppService.IAppService.Purchase.Supplier
{
    public interface ISupplierAppService : ISmAppService<dtoCreateSupplier, dtoUpdateSupplier, dtoDetailSupplier, dtoListSupplier>
    {
    }
}