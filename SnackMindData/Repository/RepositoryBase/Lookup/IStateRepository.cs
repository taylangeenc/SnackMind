using SnackMindCore.RepositoryBase;

using SnackMindModel.Lookup;

namespace SnackMindData.Repository.RepositoryBase.Lookup
{
    public interface IOrderItemStateRepository : ISmRepository<mdlOrderItemState>
    {
    }
    public interface ITableStateRepository : ISmRepository<mdlTableState>
    {
    }
    public interface IPaymentTypeRepository : ISmRepository<mdlPaymentType>
    {
    }
    public interface IReservationStateRepository : ISmRepository<mdlReservationState>
    { 
    }
    public interface IStockMovementTypeRepository : ISmRepository<mdlStockMovementType>
    { 
    }
    public interface IPurchaseOrderStateRepository : ISmRepository<mdlPurchaseOrderState>
    { 
    }
    public interface IPrintDestinationRepository : ISmRepository<mdlPrintDestination>
    { 
    }
    public interface IPrintStateRepository : ISmRepository<mdlPrintState>
    { 
    }
    public interface IPrinterConnectionTypeRepository : ISmRepository<mdlPrinterConnectionType>
    { 
    }
    public interface ILogTypeRepository : ISmRepository<mdlLogType>
    { 
    }
}