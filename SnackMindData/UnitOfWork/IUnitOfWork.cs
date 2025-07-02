using SnackMindData.Repository.RepositoryBase.Lookup;
using SnackMindData.Repository.RepositoryBase.Order.Order;
using SnackMindData.Repository.RepositoryBase.Payment.Payment;
using SnackMindData.Repository.RepositoryBase.Place.Branch;
using SnackMindData.Repository.RepositoryBase.Place.Firm;
using SnackMindData.Repository.RepositoryBase.Place.Warehouse;
using SnackMindData.Repository.RepositoryBase.Place.Zone;
using SnackMindData.Repository.RepositoryBase.Product.Category;
using SnackMindData.Repository.RepositoryBase.Product.Product;
using SnackMindData.Repository.RepositoryBase.Product.Recipe.Ingredient;
using SnackMindData.Repository.RepositoryBase.Product.Recipe.Recipe;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Ingredient;
using SnackMindData.Repository.RepositoryBase.Product.Stock.Product;
using SnackMindData.Repository.RepositoryBase.Product.Unit;
using SnackMindData.Repository.RepositoryBase.Product.Variant;
using SnackMindData.Repository.RepositoryBase.Purchase.Purchase;
using SnackMindData.Repository.RepositoryBase.Purchase.Supplier;
using SnackMindData.Repository.RepositoryBase.Reservation.Customer;
using SnackMindData.Repository.RepositoryBase.Reservation.Reservation;
using SnackMindData.Repository.RepositoryBase.Setting.Log;
using SnackMindData.Repository.RepositoryBase.Setting.Printer;
using SnackMindData.Repository.RepositoryBase.Table.Table;
using SnackMindData.Repository.RepositoryBase.User.CashShift;
using SnackMindData.Repository.RepositoryBase.User.Role;
using SnackMindData.Repository.RepositoryBase.User.User;

using System.Threading.Tasks;

namespace SnackMindData.UnitOfWork
{
    public interface IUnitOfWork
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
        ILogTypeRepository LogType { get; }

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

        ILogRepository Log { get; }
        IPrinterRepository Printer { get; }

        ITableRepository Table { get; }

        ICashShiftRepository CashShift { get; }
        IRoleRepository Role { get; }
        IUserRepository User { get; }
    }
}