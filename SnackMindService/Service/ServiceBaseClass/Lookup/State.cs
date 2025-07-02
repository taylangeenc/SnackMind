using SnackMindData.UnitOfWork;

using SnackMindModel.Lookup;

using SnackMindService.Service.ServiceBase.Lookup;

namespace SnackMindService.Service.ServiceBaseClass.Lookup
{
    public class mngOrderItemState : SmService<mdlOrderItemState>, IOrderItemStateService
    {
        public mngOrderItemState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.OrderItemState)
        {
            
        }
    }
    public class mngTableState : SmService<mdlTableState>, ITableStateService
    {
        public mngTableState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.TableState)
        {
            
        }
    }
    public class mngPaymentType : SmService<mdlPaymentType>, IPaymentTypeService
    {
        public mngPaymentType(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.PaymentType)
        {
            
        }
    }
    public class mngReservationState : SmService<mdlReservationState>, IReservationStateService
    {
        public mngReservationState(IUnitOfWork unitOfWork) : base(unitOfWork, unitOfWork.ReservationState)
        {
            mngPaymentType mngPaymentType = new mngPaymentType();
        }
    }
}