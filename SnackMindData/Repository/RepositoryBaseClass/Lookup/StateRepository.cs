using SnackMindData.Context;
using SnackMindData.Repository.RepositoryBase.Lookup;

using SnackMindModel.Lookup;

namespace SnackMindData.Repository.RepositoryBaseClass.Lookup
{
    public class OrderItemStateRepository : SmRepository<mdlOrderItemState>, IOrderItemStateRepository
    {
        public OrderItemStateRepository(SmContext context) : base(context) { }
    }

    public class LogTypeRepository : SmRepository<mdlLogType>, ILogTypeRepository
    {
        public LogTypeRepository(SmContext context) : base(context) { }
    }

    public class PaymentTypeRepository : SmRepository<mdlPaymentType>, IPaymentTypeRepository
    {
        public PaymentTypeRepository(SmContext context) : base(context) { }
    }

    public class PrintDestinationRepository : SmRepository<mdlPrintDestination>, IPrintDestinationRepository
    {
        public PrintDestinationRepository(SmContext context) : base(context) { }
    }

    public class PrintStateRepository : SmRepository<mdlPrintState>, IPrintStateRepository
    {
        public PrintStateRepository(SmContext context) : base(context) { }
    }

    public class PrinterConnectionTypeRepository : SmRepository<mdlPrinterConnectionType>, IPrinterConnectionTypeRepository
    {
        public PrinterConnectionTypeRepository(SmContext context) : base(context) { }
    }

    public class PurchaseOrderStateRepository : SmRepository<mdlPurchaseOrderState>, IPurchaseOrderStateRepository
    {
        public PurchaseOrderStateRepository(SmContext context) : base(context) { }
    }

    public class ReservationStateRepository : SmRepository<mdlReservationState>, IReservationStateRepository
    {
        public ReservationStateRepository(SmContext context) : base(context) { }
    }

    public class StockMovementTypeRepository : SmRepository<mdlStockMovementType>, IStockMovementTypeRepository
    {
        public StockMovementTypeRepository(SmContext context) : base(context) { }
    }

    public class TableStateRepository : SmRepository<mdlTableState>, ITableStateRepository
    {
        public TableStateRepository(SmContext context) : base(context) { }
    }
}
