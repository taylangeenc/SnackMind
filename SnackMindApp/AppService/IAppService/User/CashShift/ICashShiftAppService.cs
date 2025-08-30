using SnackMindApp.AppService.Base;

using SnackMindDTOs.DTOs.User.CashShift;

namespace SnackMindApp.AppService.IAppService.User.CashShift
{
    public interface ICashShiftAppService : ISmAppService<dtoCreateCashShift, dtoUpdateCashShift, dtoDetailCashShift, dtoListCashShift>
    {
    }
}