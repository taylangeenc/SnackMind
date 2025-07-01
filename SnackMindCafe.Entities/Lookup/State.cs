using SnackMindCore.BaseClass;

using SnackMindModel.Order.Order;
using SnackMindModel.Payment.Payment;
using SnackMindModel.Product.Stock;
using SnackMindModel.Purchase.Purchase;
using SnackMindModel.Reservation.Reservation;
using SnackMindModel.Setting.Log;
using SnackMindModel.Setting.Printer;
using SnackMindModel.Table.Table;

using System.Collections.Generic;

namespace SnackMindModel.Lookup
{
    public class mdlOrderItemState : EntityCard
    {
        public virtual ICollection<mdlOrderItem> OrderItems { get; set; }
    }

    public class mdlTableState : EntityCard
    {
        public virtual ICollection<mdlTable> Tables { get; set; }
    }

    public class mdlPaymentType : EntityCard
    {
        public virtual ICollection<mdlPayment> Payments { get; set; }
    }

    public class mdlReservationState : EntityCard
    {
        public virtual ICollection<mdlReservation> Reservations { get; set; }
    }

    public class mdlStockMovementType : EntityCard
    {
        public virtual ICollection<mdlProductStockMovement> ProductStockMovements { get; set; }
        public virtual ICollection<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
    }

    public class mdlPurchaseOrderState : EntityCard
    {
        public virtual ICollection<mdlPurchaseOrder> PurchaseOrders { get; set; }
    }

    public class mdlPrintDestination : EntityCard
    {
        public virtual ICollection<mdlPrinter> Printers { get; set; }
    }

    public class mdlPrintState : EntityCard
    {
        public virtual ICollection<mdlPrinter> Printers { get; set; }
    }

    public class mdlPrinterConnectionType : EntityCard
    {
        public virtual ICollection<mdlPrinter> Printers { get; set; }
    }
    public class mdlLogType : EntityCard
    {
        public virtual ICollection<mdlLog> Logs { get; set; }
    }
}