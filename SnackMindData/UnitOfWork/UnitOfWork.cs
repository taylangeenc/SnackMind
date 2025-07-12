using SnackMindData.Context;
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
using SnackMindData.Repository.Repository.Order.Order;
using SnackMindData.Repository.Repository.Payment.Payment;
using SnackMindData.Repository.Repository.Place.Branch;
using SnackMindData.Repository.Repository.Place.Firm;
using SnackMindData.Repository.Repository.Place.Warehouse;
using SnackMindData.Repository.Repository.Place.Zone;
using SnackMindData.Repository.Repository.Product.Category;
using SnackMindData.Repository.Repository.Product.Ingredient;
using SnackMindData.Repository.Repository.Product.Product;
using SnackMindData.Repository.Repository.Product.Recipe;
using SnackMindData.Repository.Repository.Product.Stock;
using SnackMindData.Repository.Repository.Product.Stock.Ingredient;
using SnackMindData.Repository.Repository.Product.Stock.Product;
using SnackMindData.Repository.Repository.Product.Unit;
using SnackMindData.Repository.Repository.Product.Variant;
using SnackMindData.Repository.Repository.Purchase.Purchase.Ingredient;
using SnackMindData.Repository.Repository.Purchase.Purchase.Product;
using SnackMindData.Repository.Repository.Purchase.Purchase.Purchase;
using SnackMindData.Repository.Repository.Purchase.Supplier;
using SnackMindData.Repository.Repository.Reservation.Customer;
using SnackMindData.Repository.Repository.Reservation.Reservation;
using SnackMindData.Repository.Repository.Setting.Printer;
using SnackMindData.Repository.Repository.Setting.Save;
using SnackMindData.Repository.Repository.Table.Table;
using SnackMindData.Repository.Repository.User.CashShift;
using SnackMindData.Repository.Repository.User.Role;
using SnackMindData.Repository.Repository.User.User;

using System.Data.Entity;
using System.Threading.Tasks;

namespace SnackMindData.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SmContext _context;
        private DbContextTransaction _transaction;
        #region IRepositorys
        public IOrderItemStateRepository OrderItemState { get; private set; }

        public ITableStateRepository TableState { get; private set; }

        public IPaymentTypeRepository PaymentType { get; private set; }

        public IReservationStateRepository ReservationState { get; private set; }

        public IStockMovementTypeRepository StockMovementType { get; private set; }

        public IPurchaseOrderStateRepository PurchaseOrderState { get; private set; }

        public IPrintDestinationRepository PrintDestination { get; private set; }

        public IPrintStateRepository PrintState { get; private set; }

        public IPrinterConnectionTypeRepository PrinterConnectionType { get; private set; }

        public ISaveTypeRepository SaveType { get; private set; }

        public IOrderRepository Order { get; private set; }

        public IOrderItemRepository OrderItem { get; private set; }

        public IPaymentRepository Payment { get; private set; }

        public IBranchRepository Branch { get; private set; }

        public IFirmRepository Firm { get; private set; }

        public IWarehouseRepository Warehouse { get; private set; }

        public IZoneRepository Zone { get; private set; }

        public IProductCategoryRepository ProductCategory { get; private set; }

        public IParentCategoryRepository ParentCategory { get; private set; }

        public IProductRepository Product { get; private set; }

        public IIngredientRepository Ingredient { get; private set; }

        public IRecipeRepository Recipe { get; private set; }

        public IRecipeItemRepository RecipeItem { get; private set; }

        public IIngredientStockRepository IngredientStock { get; private set; }

        public IIngredientStockMovementRepository IngredientStockMovement { get; private set; }

        public IProductStockRepository ProductStock { get; private set; }

        public IProductStockMovementRepository ProductStockMovement { get; private set; }

        public IUnitRepository Unit { get; private set; }

        public IProductVariantRepository ProductVariant { get; private set; }

        public IPurchaseOrderRepository PurchaseOrder { get; private set; }

        public IIngredientPurchaseOrderItemRepository IngredientPurchaseOrderItem { get; private set; }

        public IProductPurchaseOrderItemRepository ProductPurchaseOrderItem { get; private set; }

        public ISupplierRepository Supplier { get; private set; }

        public IReservationRepository Reservation { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public ISaveRepository Save { get; private set; }

        public IPrinterRepository Printer { get; private set; }

        public ITableRepository Table { get; private set; }

        public ICashShiftRepository CashShift { get; private set; }

        public IRoleRepository Role { get; private set; }

        public IUserRepository User { get; private set; }
        #endregion
        public UnitOfWork(SmContext context)
        {
            _context = context;

            #region Initialize IRepositorys
            OrderItemState = new OrderItemStateRepository(_context);
            TableState = new TableStateRepository(_context);
            PaymentType = new PaymentTypeRepository(_context);
            ReservationState = new ReservationStateRepository(_context);
            StockMovementType = new StockMovementTypeRepository(_context);
            PurchaseOrderState = new PurchaseOrderStateRepository(_context);
            PrintDestination = new PrintDestinationRepository(_context);
            PrintState = new PrintStateRepository(_context);
            PrinterConnectionType = new PrinterConnectionTypeRepository(_context);
            SaveType = new SaveTypeRepository(_context);

            Order = new OrderRepository(_context);
            OrderItem = new OrderItemRepository(_context);
            Payment = new PaymentRepository(_context);
            Branch = new BranchRepository(_context);
            Firm = new FirmRepository(_context);
            Warehouse = new WarehouseRepository(_context);
            Zone = new ZoneRepository(_context);
            ProductCategory = new ProductCategoryRepository(_context);
            ParentCategory = new ParentCategoryRepository(_context);
            Product = new ProductRepository(_context);
            Ingredient = new IngredientRepository(_context);
            Recipe = new RecipeRepository(_context);
            RecipeItem = new RecipeItemRepository(_context);
            IngredientStock = new IngredientStockRepository(_context);
            IngredientStockMovement = new IngredientStockMovementRepository(_context);
            ProductStock = new ProductStockRepository(_context);
            ProductStockMovement = new ProductStockMovementRepository(_context);
            Unit = new UnitRepository(_context);
            ProductVariant = new ProductVariantRepository(_context);
            PurchaseOrder = new PurchaseOrderRepository(_context);
            IngredientPurchaseOrderItem = new IngredientPurchaseOrderItemRepository(_context);
            ProductPurchaseOrderItem = new ProductPurchaseOrderItemRepository(_context);
            Supplier = new SupplierRepository(_context);
            Reservation = new ReservationRepository(_context);
            Customer = new CustomerRepository(_context);
            Save = new SaveRepository(_context);
            Printer = new PrinterRepository(_context);
            Table = new TableRepository(_context);
            CashShift = new CashShiftRepository(_context);
            Role = new RoleRepository(_context);
            User = new UserRepository(_context);
            #endregion
        }
        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction?.Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
        }
    }
}