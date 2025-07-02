using SnackMindData.Context;
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
using SnackMindData.Repository.RepositoryBaseClass.Order.Order;
using SnackMindData.Repository.RepositoryBaseClass.Payment.Payment;
using SnackMindData.Repository.RepositoryBaseClass.Place.Branch;
using SnackMindData.Repository.RepositoryBaseClass.Place.Firm;
using SnackMindData.Repository.RepositoryBaseClass.Place.Warehouse;
using SnackMindData.Repository.RepositoryBaseClass.Place.Zone;
using SnackMindData.Repository.RepositoryBaseClass.Product.Category;
using SnackMindData.Repository.RepositoryBaseClass.Product.Product;
using SnackMindData.Repository.RepositoryBaseClass.Product.Recipe.Ingredient;
using SnackMindData.Repository.RepositoryBaseClass.Product.Recipe.Recipe;
using SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Ingredient;
using SnackMindData.Repository.RepositoryBaseClass.Product.Stock.Product;
using SnackMindData.Repository.RepositoryBaseClass.Product.Unit;
using SnackMindData.Repository.RepositoryBaseClass.Product.Variant;
using SnackMindData.Repository.RepositoryBaseClass.Purchase.Purchase;
using SnackMindData.Repository.RepositoryBaseClass.Purchase.Supplier;
using SnackMindData.Repository.RepositoryBaseClass.Reservation.Customer;
using SnackMindData.Repository.RepositoryBaseClass.Reservation.Reservation;
using SnackMindData.Repository.RepositoryBaseClass.Setting.Log;
using SnackMindData.Repository.RepositoryBaseClass.Setting.Printer;
using SnackMindData.Repository.RepositoryBaseClass.Table.Table;
using SnackMindData.Repository.RepositoryBaseClass.User.CashShift;
using SnackMindData.Repository.RepositoryBaseClass.User.Role;
using SnackMindData.Repository.RepositoryBaseClass.User.User;

using System.Data.Entity;
using System.Threading.Tasks;

namespace SnackMindData.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SmContext _context;
        private DbContextTransaction _transaction;
        public UnitOfWork(SmContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction?.Dispose();
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        private IOrderRepository _order;
        public IOrderRepository Order { get { return _order ?? (_order = new OrderRepository(_context)); } }

        private IOrderItemRepository _orderItem;
        public IOrderItemRepository OrderItem { get { return _orderItem ?? (_orderItem = new OrderItemRepository(_context)); } }

        private IPaymentRepository _payment;
        public IPaymentRepository Payment { get { return _payment ?? (_payment = new PaymentRepository(_context)); } }

        private IBranchRepository _branch;
        public IBranchRepository Branch { get { return _branch ?? (_branch = new BranchRepository(_context)); } }

        private IFirmRepository _firm;
        public IFirmRepository Firm { get { return _firm ?? (_firm = new FirmRepository(_context)); } }

        private IWarehouseRepository _warehouse;
        public IWarehouseRepository Warehouse { get { return _warehouse ?? (_warehouse = new WarehouseRepository(_context)); } }

        private IZoneRepository _zone;
        public IZoneRepository Zone { get { return _zone ?? (_zone = new ZoneRepository(_context)); } }

        private IProductCategoryRepository _productCategory;
        public IProductCategoryRepository ProductCategory { get { return _productCategory ?? (_productCategory = new ProductCategoryRepository(_context)); } }

        private IParentCategoryRepository _parentCategory;
        public IParentCategoryRepository ParentCategory { get { return _parentCategory ?? (_parentCategory = new ParentCategoryRepository(_context)); } }

        private IProductRepository _product;
        public IProductRepository Product { get { return _product ?? (_product = new ProductRepository(_context)); } }

        private IIngredientRepository _ingredient;
        public IIngredientRepository Ingredient { get { return _ingredient ?? (_ingredient = new IngredientRepository(_context)); } }

        private IRecipeRepository _recipe;
        public IRecipeRepository Recipe { get { return _recipe ?? (_recipe = new RecipeRepository(_context)); } }

        private IRecipeItemRepository _recipeItem;
        public IRecipeItemRepository RecipeItem { get { return _recipeItem ?? (_recipeItem = new RecipeItemRepository(_context)); } }

        private IIngredientStockRepository _ingredientStock;
        public IIngredientStockRepository IngredientStock { get { return _ingredientStock ?? (_ingredientStock = new IngredientStockRepository(_context)); } }

        private IIngredientStockMovementRepository _ingredientStockMovement;
        public IIngredientStockMovementRepository IngredientStockMovement { get { return _ingredientStockMovement ?? (_ingredientStockMovement = new IngredientStockMovementRepository(_context)); } }

        private IProductStockRepository _productStock;
        public IProductStockRepository ProductStock { get { return _productStock ?? (_productStock = new ProductStockRepository(_context)); } }

        private IProductStockMovementRepository _productStockMovement;
        public IProductStockMovementRepository ProductStockMovement { get { return _productStockMovement ?? (_productStockMovement = new ProductStockMovementRepository(_context)); } }

        private IUnitRepository _unit;
        public IUnitRepository Unit { get { return _unit ?? (_unit = new UnitRepository(_context)); } }

        private IProductVariantRepository _productVariant;
        public IProductVariantRepository ProductVariant { get { return _productVariant ?? (_productVariant = new ProductVariantRepository(_context)); } }

        private IPurchaseOrderRepository _purchaseOrder;
        public IPurchaseOrderRepository PurchaseOrder { get { return _purchaseOrder ?? (_purchaseOrder = new PurchaseOrderRepository(_context)); } }

        private IIngredientPurchaseOrderItemRepository _ingredientPurchaseOrderItem;
        public IIngredientPurchaseOrderItemRepository IngredientPurchaseOrderItem { get { return _ingredientPurchaseOrderItem ?? (_ingredientPurchaseOrderItem = new IngredientPurchaseOrderItemRepository(_context)); } }

        private IProductPurchaseOrderItemRepository _productPurchaseOrderItem;
        public IProductPurchaseOrderItemRepository ProductPurchaseOrderItem { get { return _productPurchaseOrderItem ?? (_productPurchaseOrderItem = new ProductPurchaseOrderItemRepository(_context)); } }

        private ISupplierRepository _supplier;
        public ISupplierRepository Supplier { get { return _supplier ?? (_supplier = new SupplierRepository(_context)); } }

        private IReservationRepository _reservation;
        public IReservationRepository Reservation { get { return _reservation ?? (_reservation = new ReservationRepository(_context)); } }

        private ICustomerRepository _customer;
        public ICustomerRepository Customer { get { return _customer ?? (_customer = new CustomerRepository(_context)); } }

        private ILogRepository _log;
        public ILogRepository Log { get { return _log ?? (_log = new LogRepository(_context)); } }

        private IPrinterRepository _printer;
        public IPrinterRepository Printer { get { return _printer ?? (_printer = new PrinterRepository(_context)); } }

        private ITableRepository _table;
        public ITableRepository Table { get { return _table ?? (_table = new TableRepository(_context)); } }

        private ICashShiftRepository _cashShift;
        public ICashShiftRepository CashShift { get { return _cashShift ?? (_cashShift = new CashShiftRepository(_context)); } }

        private IRoleRepository _role;
        public IRoleRepository Role { get { return _role ?? (_role = new RoleRepository(_context)); } }

        private IUserRepository _user;
        public IUserRepository User { get { return _user ?? (_user = new UserRepository(_context)); } }
    }
}