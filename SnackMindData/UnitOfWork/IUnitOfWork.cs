using SnackMindData.Repository.IRepository.Order.Order;
using SnackMindData.Repository.IRepository.Payment.Payment;
using SnackMindData.Repository.IRepository.Place.Branch;
using SnackMindData.Repository.IRepository.Place.Firm;
using SnackMindData.Repository.IRepository.Place.Warehouse;
using SnackMindData.Repository.IRepository.Place.Zone;
using SnackMindData.Repository.IRepository.Product.Category;
using SnackMindData.Repository.IRepository.Product.Ingredient;
using SnackMindData.Repository.IRepository.Product.Product;
using SnackMindData.Repository.IRepository.Product.Recipe;
using SnackMindData.Repository.IRepository.Product.Stock;
using SnackMindData.Repository.IRepository.Product.Stock.Ingredient;
using SnackMindData.Repository.IRepository.Product.Stock.Product;
using SnackMindData.Repository.IRepository.Product.Unit;
using SnackMindData.Repository.IRepository.Product.Variant;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Ingredient;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Product;
using SnackMindData.Repository.IRepository.Purchase.Purchase.Purchase;
using SnackMindData.Repository.IRepository.Purchase.Supplier;
using SnackMindData.Repository.IRepository.Reservation.Customer;
using SnackMindData.Repository.IRepository.Reservation.Reservation;
using SnackMindData.Repository.IRepository.Setting.Printer;
using SnackMindData.Repository.IRepository.Setting.Save;
using SnackMindData.Repository.IRepository.Table.Table;
using SnackMindData.Repository.IRepository.User.CashShift;
using SnackMindData.Repository.IRepository.User.Role;
using SnackMindData.Repository.IRepository.User.User;

using System;
using System.Threading.Tasks;

namespace SnackMindData.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        Task<int> CommitAsync();

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

        IOrderItemStateRepository OrderItemState { get; }
        ITableStateRepository TableState { get; }
        IPaymentTypeRepository PaymentType { get; }
        IReservationStateRepository ReservationState { get; }
        IStockMovementTypeRepository StockMovementType { get; }
        IPurchaseOrderStateRepository PurchaseOrderState { get; }
        IPrintDestinationRepository PrintDestination { get; }
        IPrintStateRepository PrintState { get; }
        IPrinterConnectionTypeRepository PrinterConnectionType { get; }
        ISaveTypeRepository SaveType { get; }

        IOrderRepository Order { get; }
        IOrderItemRepository OrderItem { get; }

        IPaymentRepository Payment { get; }

        IBranchRepository Branch { get; }
        IFirmRepository Firm { get; }
        IWarehouseRepository Warehouse { get; }
        IZoneRepository Zone { get; }

        IProductCategoryRepository ProductCategory { get; }
        IParentCategoryRepository ParentCategory { get; }
        IProductRepository Product { get; }
        IIngredientRepository Ingredient { get; }
        IRecipeRepository Recipe { get; }
        IRecipeItemRepository RecipeItem { get; }
        IIngredientStockRepository IngredientStock { get; }
        IIngredientStockMovementRepository IngredientStockMovement { get; }
        IProductStockRepository ProductStock { get; }
        IProductStockMovementRepository ProductStockMovement { get; }
        IUnitRepository Unit { get; }
        IProductVariantRepository ProductVariant { get; }

        IPurchaseOrderRepository PurchaseOrder { get; }
        IIngredientPurchaseOrderItemRepository IngredientPurchaseOrderItem { get; }
        IProductPurchaseOrderItemRepository ProductPurchaseOrderItem { get; }
        ISupplierRepository Supplier { get; }

        IReservationRepository Reservation { get; }
        ICustomerRepository Customer { get; }

        ISaveRepository Save { get; }
        IPrinterRepository Printer { get; }

        ITableRepository Table { get; }

        ICashShiftRepository CashShift { get; }
        IRoleRepository Role { get; }
        IUserRepository User { get; }
    }
}