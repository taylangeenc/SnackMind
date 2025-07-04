using SnackMindCore.RepositoryBase;

using SnackMindData.UnitOfWork;

using SnackMindModel.Lookup;

using SnackMindService.Service.ServiceBase.Lookup;

namespace SnackMindService.Service.ServiceBaseClass.Lookup
{
    public class mngOrderItemState : SmService<mdlOrderItemState>, IOrderItemStateService
    {
        protected mngOrderItemState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.OrderItemState)
        {

        }
    }
    public class mngTableState : SmService<mdlTableState>, ITableStateService
    {
        protected mngTableState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.TableState)
        {

        }
    }
    public class mngPaymentType : SmService<mdlPaymentType>, IPaymentTypeService
    {
        protected mngPaymentType(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PaymentType)
        {

        }
    }
    public class mngReservationState : SmService<mdlReservationState>, IReservationStateService
    {
        protected mngReservationState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ReservationState)
        {

        }
    }
    public class mngStockMovementType : SmService<mdlStockMovementType>, IStockMovementTypeService
    {
        protected mngStockMovementType(IUnitOfWork unitOfWork, ISmRepository<mdlStockMovementType> repository) : base(unitOfWork, repository)
        {

        }
    }
    public class mngPurchaseOrderState : SmService<mdlPurchaseOrderState>, IPurchaseOrderStateService
    {
        protected mngPurchaseOrderState(IUnitOfWork unitOfWork, ISmRepository<mdlPurchaseOrderState> repository) : base(unitOfWork, repository)
        {

        }
    }
    public class mngPrintDestination : SmService<mdlPrintDestination>, IPrintDestinationService
    {
        protected mngPrintDestination(IUnitOfWork unitOfWork, ISmRepository<mdlPrintDestination> repository) : base(unitOfWork, repository)
        {

        }
    }
    public class mngPrintState : SmService<mdlPrintState>, IPrintStateService
    {
        protected mngPrintState(IUnitOfWork unitOfWork, ISmRepository<mdlPrintState> repository) : base(unitOfWork, repository)
        {

        }
    }
    public class mngPrinterConnectionType : SmService<mdlPrinterConnectionType>, IPrinterConnectionTypeService
    {
        protected mngPrinterConnectionType(IUnitOfWork unitOfWork, ISmRepository<mdlPrinterConnectionType> repository) : base(unitOfWork, repository)
        {

        }
    }
    public class mngLogType : SmService<mdlLogType>, ILogTypeService
    {
        protected mngLogType(IUnitOfWork unitOfWork, ISmRepository<mdlLogType> repository) : base(unitOfWork, repository)
        {

        }
    }
}