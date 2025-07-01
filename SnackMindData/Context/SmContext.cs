using SnackMindModel.Lookup;
using SnackMindModel.Order.Order;
using SnackMindModel.Payment.Payment;
using SnackMindModel.Place.Branch;
using SnackMindModel.Place.Warehouse;
using SnackMindModel.Place.Zone;
using SnackMindModel.Product.Category;
using SnackMindModel.Product.Product;
using SnackMindModel.Product.Recipe.Ingredient;
using SnackMindModel.Product.Recipe.Recipe;
using SnackMindModel.Product.Stock;
using SnackMindModel.Product.Unit;
using SnackMindModel.Product.Variant;
using SnackMindModel.Purchase.Purchase;
using SnackMindModel.Purchase.Supplier;
using SnackMindModel.Reservation.Customer;
using SnackMindModel.Reservation.Reservation;
using SnackMindModel.Setting.Log;
using SnackMindModel.Setting.Printer;
using SnackMindModel.Table.Table;
using SnackMindModel.User.CashShift;

using System.Data.Entity;

namespace SnackMindData.Context
{
    public class SmContext : DbContext
    {
        public SmContext() : base("name=connection") { }

        #region DbSet
        public DbSet<mdlBranch> Branches { get; set; }
        public DbSet<mdlCashShift> CashShifts { get; set; }
        public DbSet<mdlCustomer> Customers { get; set; }
        public DbSet<mdlIngredient> Ingredients { get; set; }
        public DbSet<mdlIngredientPurchaseOrderItem> IngredientPurchaseOrderItems { get; set; }
        public DbSet<mdlIngredientStock> IngredientStocks { get; set; }
        public DbSet<mdlIngredientStockMovement> IngredientStockMovements { get; set; }
        public DbSet<mdlLog> Logs { get; set; }
        public DbSet<mdlLogType> LogTypes { get; set; }
        public DbSet<mdlOrder> Orders { get; set; }
        public DbSet<mdlOrderItem> OrderItems { get; set; }
        public DbSet<mdlOrderItemState> OrderItemStates { get; set; }
        public DbSet<mdlParentCategory> ParentCategories { get; set; }
        public DbSet<mdlPayment> Payments { get; set; }
        public DbSet<mdlPaymentType> PaymentTypes { get; set; }
        public DbSet<mdlPrinter> Printers { get; set; }
        public DbSet<mdlPrinterConnectionType> PrinterConnectionTypes { get; set; }
        public DbSet<mdlProduct> Products { get; set; }
        public DbSet<mdlProductCategory> ProductCategories { get; set; }
        public DbSet<mdlProductPurchaseOrderItem> ProductPurchaseOrderItems { get; set; }
        public DbSet<mdlProductStock> ProductStocks { get; set; }
        public DbSet<mdlProductStockMovement> ProductStockMovements { get; set; }
        public DbSet<mdlProductVariant> ProductVariants { get; set; }
        public DbSet<mdlPurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<mdlPurchaseOrderState> PurchaseOrderStates { get; set; }
        public DbSet<mdlRecipe> Recipes { get; set; }
        public DbSet<mdlRecipeItem> RecipeItems { get; set; }
        public DbSet<mdlReservation> Reservations { get; set; }
        public DbSet<mdlReservationState> ReservationStates { get; set; }
        public DbSet<mdlStockMovementType> StockMovementTypes { get; set; }
        public DbSet<mdlTable> Tables { get; set; }
        public DbSet<mdlTableState> TableStates { get; set; }
        public DbSet<mdlUnit> Units { get; set; }
        public DbSet<mdlWarehouse> Warehouses { get; set; }
        public DbSet<mdlZone> Zones { get; set; }
        public DbSet<mdlSupplier> Suppliers { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}