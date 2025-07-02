using SnackMindCore.BaseClass;

using SnackMindModel.Lookup;
using SnackMindModel.Order.Order;
using SnackMindModel.Payment.Payment;
using SnackMindModel.Place.Branch;
using SnackMindModel.Place.Firm;
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
using SnackMindModel.User.Role;
using SnackMindModel.User.User;

using System.Data.Entity;

namespace SnackMindData.Context
{
    public class SmContext : DbContext
    {
        public SmContext() : base("name=connection") { }

        #region DbSet
        public DbSet<mdlFirm> Firms { get; set; }
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
        public DbSet<mdlRole> Roles { get; set; }
        public DbSet<mdlUser> Users { get; set; }
        public DbSet<mdlPrintDestination> PrintDestinations { get; set; }
        public DbSet<mdlPrintState> PrintStates { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Table
            modelBuilder.Entity<mdlFirm>().ToTable("Firms");
            modelBuilder.Entity<mdlBranch>().ToTable("Branches");
            modelBuilder.Entity<mdlCashShift>().ToTable("CashShifts");
            modelBuilder.Entity<mdlCustomer>().ToTable("Customers");
            modelBuilder.Entity<mdlIngredient>().ToTable("Ingredients");
            modelBuilder.Entity<mdlIngredientPurchaseOrderItem>().ToTable("IngredientPurchaseOrderItems");
            modelBuilder.Entity<mdlIngredientStock>().ToTable("IngredientStocks");
            modelBuilder.Entity<mdlIngredientStockMovement>().ToTable("IngredientStockMovements");
            modelBuilder.Entity<mdlLog>().ToTable("Logs");
            modelBuilder.Entity<mdlLogType>().ToTable("LogTypes");
            modelBuilder.Entity<mdlOrder>().ToTable("Orders");
            modelBuilder.Entity<mdlOrderItem>().ToTable("OrderItems");
            modelBuilder.Entity<mdlOrderItemState>().ToTable("OrderItemStates");
            modelBuilder.Entity<mdlParentCategory>().ToTable("ParentCategories");
            modelBuilder.Entity<mdlPayment>().ToTable("Payments");
            modelBuilder.Entity<mdlPaymentType>().ToTable("PaymentTypes");
            modelBuilder.Entity<mdlPrinter>().ToTable("Printers");
            modelBuilder.Entity<mdlPrinterConnectionType>().ToTable("PrinterConnectionTypes");
            modelBuilder.Entity<mdlProduct>().ToTable("Products");
            modelBuilder.Entity<mdlProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<mdlProductPurchaseOrderItem>().ToTable("ProductPurchaseOrderItems");
            modelBuilder.Entity<mdlProductStock>().ToTable("ProductStocks");
            modelBuilder.Entity<mdlProductStockMovement>().ToTable("ProductStockMovements");
            modelBuilder.Entity<mdlProductVariant>().ToTable("ProductVariants");
            modelBuilder.Entity<mdlPurchaseOrder>().ToTable("PurchaseOrders");
            modelBuilder.Entity<mdlPurchaseOrderState>().ToTable("PurchaseOrderStates");
            modelBuilder.Entity<mdlRecipe>().ToTable("Recipes");
            modelBuilder.Entity<mdlRecipeItem>().ToTable("RecipeItems");
            modelBuilder.Entity<mdlReservation>().ToTable("Reservations");
            modelBuilder.Entity<mdlReservationState>().ToTable("ReservationStates");
            modelBuilder.Entity<mdlStockMovementType>().ToTable("StockMovementTypes");
            modelBuilder.Entity<mdlTable>().ToTable("Tables");
            modelBuilder.Entity<mdlTableState>().ToTable("TableStates");
            modelBuilder.Entity<mdlUnit>().ToTable("Units");
            modelBuilder.Entity<mdlWarehouse>().ToTable("Warehouses");
            modelBuilder.Entity<mdlZone>().ToTable("Zones");
            modelBuilder.Entity<mdlSupplier>().ToTable("Suppliers");
            modelBuilder.Entity<mdlRole>().ToTable("Roles");
            modelBuilder.Entity<mdlUser>().ToTable("Users");
            modelBuilder.Entity<mdlPrintDestination>().ToTable("PrintDestinations");
            modelBuilder.Entity<mdlPrintState>().ToTable("PrintStates");
            #endregion

            #region Primary Key
            modelBuilder.Entity<Entity>().HasKey(x => x.Ref);
            #endregion

            #region Mapping
            modelBuilder.Entity<EntityCard>().Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<EntityCard>().Property(x => x.Description).HasColumnType("nvarchar").HasMaxLength(500).IsOptional();
            #endregion
        }
    }
}